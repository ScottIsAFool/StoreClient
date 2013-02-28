using StoreClient.Entities;

namespace StoreClient
{
    public static class Extensions
    {
        public static string ToEnumString(this ScreenSize screenSize)
        {
            var height = "480";
            switch (screenSize)
            {
                case ScreenSize.SevenTwentyP:
                    height = "720";
                    break;
                case ScreenSize.Wvga:
                    height = "480";
                    break;
                case ScreenSize.Wxga:
                    height = "768";
                    break;
            }
            return height;
        }
    }
}
