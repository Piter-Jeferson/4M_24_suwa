namespace _4M_24_suwa
{
    public class Uczen
    {
        public int id { get; set; }
        public string imie { get; set; }
        public string klasa { get; set; }
        public Uczen(int id, string imie, string klasa)
        {
            this.id = id;
            this.imie = imie;
            this.klasa = klasa;
        }
        public override string ToString()
        {
            return $"{id} {imie} {klasa}";
        }
    }
    public class Uczniowie
    {
        public static List<Uczen> uczniowie = new List<Uczen>()
            {
               new(1, "Ala", "3L")
            };

    }
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void valueChanged(object sender, EventArgs e)
        {
            lblHello.FontSize = sldHello.Value;
        }
    }

}
