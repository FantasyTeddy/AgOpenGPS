using System;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace AgDiag.Protocol
{
    public class UdpCommunication
    {
        private readonly Pgns _pgns;

        private readonly CancellationTokenSource _cancellationTokenSource = new();

        private int cntr;

        public UdpCommunication(Pgns pgns)
        {
            _pgns = pgns;
        }

        public event EventHandler<int> DefaultSendsUpdated;

        public void LoadLoopback()
        {
            CancellationToken cancellationToken = _cancellationTokenSource.Token;
            Task.Factory.StartNew(() => ReceiveLoopAsync(cancellationToken), cancellationToken, TaskCreationOptions.LongRunning, TaskScheduler.Default);
        }

        public void CloseLoopback()
        {
            _cancellationTokenSource.Cancel();
        }

        private async Task ReceiveLoopAsync(CancellationToken cancellationToken)
        {
            try
            {
                using UdpClient udpClient = new(17777);
                while (!cancellationToken.IsCancellationRequested)
                {
                    UdpReceiveResult result = await udpClient.ReceiveAsync().ConfigureAwait(false);

                    HandleMessage(result.Buffer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UDP Error: " + ex.Message, "UDP Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleMessage(byte[] data)
        {
            if (data[0] == 0x80 && data[1] == 0x81)
            {
                switch (data[3])
                {
                    case 253:
                        {
                            _pgns.asModule.SetBytesFromMessage(data);
                            break;
                        }
                    case 254:
                        {
                            _pgns.asData.SetBytesFromMessage(data);
                            break;
                        }
                    case 252:
                        {
                            _pgns.asSet.SetBytesFromMessage(data);
                            break;
                        }
                    case 251:
                        {
                            _pgns.asConfig.SetBytesFromMessage(data);
                            break;
                        }
                    case 239:
                        {
                            _pgns.maData.SetBytesFromMessage(data);
                            break;
                        }

                    default:
                        {
                            DefaultSendsUpdated?.Invoke(this, data.Length);
                            break;
                        }
                }
            }
            else
            {
                cntr += data.Length;
                DefaultSendsUpdated?.Invoke(this, cntr);
            }
        }
    }
}
