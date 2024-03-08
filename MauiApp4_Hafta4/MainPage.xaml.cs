namespace MauiApp4_Hafta4
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            listKisiler.ItemsSource = contacts;
        }

        List<MContact> contacts = new List<MContact> {
            new MContact() { Name = "Ali", Surname="Kara", Email="alikara@mail.com", Phone="0597 987 65 32", Image="user.png" },
            new MContact() { Name = "Ayşe", Surname="Sarı", Email="aysesari@mail.com", Phone="0589 987 56 32", Image="user.png" },
            new MContact() { Name = "Ahmet", Surname="Beyaz", Email="ahmetbeyaz@mail.com", Phone="0577 555 56 32", Image="user.png" }
        };
        
    }


    public class MContact
    {
        public MContact() { }
        string id,name,surname,phone,email, image;

        public string ID
        {
            get
            {
                if (id == null)
                    id = Guid.NewGuid().ToString();
                return id;
            }
            set { id = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string FullName => name + " " + surname;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Image
        {
            get { return image; }
            set { image = value; }
        }

    }
}
