namespace _4_3_1_itec_111_activity_3
{
    public class Caesar : Cipher
    {
        public const string Characters = "abcdefghijklmnopqrstuvwxyz";
        public const int MinKey = 0;
        public static int MaxKey => Characters.Length - 1;

        protected int _defaultKey;
        public int defaultKey
        {
            get => _defaultKey;
            set => _defaultKey = Limit(value);
        }

        public Caesar(int defaultKey)
        {
            this.defaultKey = defaultKey;
        }

        public override string Decrypt(string text)
        {
            return Decrypt(text, defaultKey);
        }

        public override string Encrypt(string text)
        {
            return Encrypt(text, defaultKey);
        }

        public static string Decrypt(string str, int key)
        {
            key = Limit(key);
            return _Perform(str, -key);
        }

        public static string Encrypt(string str, int key)
        {
            key = Limit(key);
            return _Perform(str, key);
        }

        protected static string _Perform(string str, int key)
        {
            return string.Concat(
                from c in str.Trim().ToLower().Select(
                    (c, i) => new KeyValuePair<int, char>(
                        Characters.Contains(c)
                        ? Characters.IndexOf(c) : -1, c))
                select (
                    c.Key != -1
                    ? (c.Key + key >= 0
                       ? Characters[((c.Key + key) % (MaxKey + 1))]
                       : Characters[(MaxKey + 1) + ((c.Key + key) % (MaxKey + 1))]
                    )
                    : c.Value
                )
            );
        }

        public static int Limit(int key)
        {
            return Math.Min(Math.Max(key, MinKey), MaxKey);
        }
    }
}
