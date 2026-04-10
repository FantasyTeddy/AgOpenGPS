using AgOpenGPS.Core.Models;
using AgOpenGPS.ResourcesBrands;
using System.ComponentModel;
using System.Drawing;

namespace AgOpenGPS
{
    public static class TractorBitmaps
    {
        public static Bitmap GetBitmap(TractorBrand brand)
        {
            return brand switch
            {
                TractorBrand.Case => BrandImages.TractorCase,
                TractorBrand.Claas => BrandImages.TractorClaas,
                TractorBrand.Deutz => BrandImages.TractorDeutz,
                TractorBrand.Fendt => BrandImages.TractorFendt,
                TractorBrand.JohnDeere => BrandImages.TractorJohnDeere,
                TractorBrand.Kubota => BrandImages.TractorKubota,
                TractorBrand.Massey => BrandImages.TractorMassey,
                TractorBrand.NewHolland => BrandImages.TractorNewHolland,
                TractorBrand.Same => BrandImages.TractorSame,
                TractorBrand.Steyr => BrandImages.TractorSteyr,
                TractorBrand.Ursus => BrandImages.TractorUrsus,
                TractorBrand.Valtra => BrandImages.TractorValtra,
                TractorBrand.JCB => BrandImages.TractorJCB,
                TractorBrand.AGOpenGPS => BrandImages.TractorAoG,
                _ => throw new InvalidEnumArgumentException(nameof(brand), (int)brand, typeof(TractorBrand)),
            };
        }
    }

    public static class HarvesterBitmaps
    {
        public static Bitmap GetBitmap(HarvesterBrand brand)
        {
            return brand switch
            {
                HarvesterBrand.Case => BrandImages.HarvesterCase,
                HarvesterBrand.Claas => BrandImages.HarvesterClaas,
                HarvesterBrand.JohnDeere => BrandImages.HarvesterJohnDeere,
                HarvesterBrand.NewHolland => BrandImages.HarvesterNewHolland,
                HarvesterBrand.AgOpenGPS => BrandImages.HarvesterAoG,
                _ => throw new InvalidEnumArgumentException(nameof(brand), (int)brand, typeof(HarvesterBrand)),
            };
        }
    }

    public static class ArticulatedBitmaps
    {
        public static Bitmap GetFrontBitmap(ArticulatedBrand brand)
        {
            return brand switch
            {
                ArticulatedBrand.Case => BrandImages.ArticulatedFrontCase,
                ArticulatedBrand.Challenger => BrandImages.ArticulatedFrontChallenger,
                ArticulatedBrand.JohnDeere => BrandImages.ArticulatedFrontJohnDeere,
                ArticulatedBrand.NewHolland => BrandImages.ArticulatedFrontNewHolland,
                ArticulatedBrand.Holder => BrandImages.ArticulatedFrontHolder,
                ArticulatedBrand.AgOpenGPS => BrandImages.ArticulatedFrontAoG,
                _ => throw new InvalidEnumArgumentException(nameof(brand), (int)brand, typeof(ArticulatedBrand)),
            };
        }

        public static Bitmap GetRearBitmap(ArticulatedBrand brand)
        {
            return brand switch
            {
                ArticulatedBrand.Case => BrandImages.ArticulatedRearCase,
                ArticulatedBrand.Challenger => BrandImages.ArticulatedRearChallenger,
                ArticulatedBrand.JohnDeere => BrandImages.ArticulatedRearJohnDeere,
                ArticulatedBrand.NewHolland => BrandImages.ArticulatedRearNewHolland,
                ArticulatedBrand.Holder => BrandImages.ArticulatedRearHolder,
                ArticulatedBrand.AgOpenGPS => BrandImages.ArticulatedRearAoG,
                _ => throw new InvalidEnumArgumentException(nameof(brand), (int)brand, typeof(ArticulatedBrand)),
            };
        }
    }
}
