namespace _4_3_1_itec_111_activity_3
{
    public partial class CaesarParameters : Form
    {
        public virtual Caesar cipher => Session.ciphers.GetValueOrDefault("Caesar") as Caesar;

        public CaesarParameters()
        {
            InitializeComponent();
            if (cipher != null)
            {
                keySlider.Minimum = Caesar.MinKey;
                keySlider.Maximum = Caesar.MaxKey;
                keySlider.Value = cipher.defaultKey;

                keyInput.Minimum = Caesar.MinKey;
                keyInput.Maximum = Caesar.MaxKey;
                keyInput.Value = cipher.defaultKey;
            }
        }

        public virtual void ChangeKey(int key)
        {
            if (cipher != null)
            {
                cipher.defaultKey = key;
                keySlider.Value = cipher.defaultKey;
                keyInput.Value = cipher.defaultKey;
            }
        }

        private void ChangeKey(object sender, EventArgs e)
        {
            var slider = sender as TrackBar;
            if (slider != null) ChangeKey(slider.Value);
            else ChangeKey(Convert.ToInt32((sender as NumericUpDown).Value));
        }
    }
}
