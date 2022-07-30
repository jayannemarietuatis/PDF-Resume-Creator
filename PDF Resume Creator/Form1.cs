using Newtonsoft.Json;


namespace PDF_Resume_Creator
{
    public partial class formResume : Form
    {
        public formResume()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<Resume> applicants = new List<Resume>();
            Resume r1 = new Resume()
            {
                Name = txtbxName.Text,
                Number = txtbxContact.Text,
                Email = txtbxEmail.Text,
                Address = txtbxAddress.Text,
                Introduction = txtbxIntro.Text,
                Birthday = txtbxBirth.Text,
                Father = txtbxFather.Text,
                FatherOccupation = txtbxFatherOcc.Text,
                Mother = txtbxMother.Text,
                MotherOccupation = txtbxMotherOcc.Text,
                Skill1 = txtbxSkill1.Text,
                Skill2 = txtbxSkill2.Text,
                Skill3 = txtbxSkill3.Text,
                Skill4 = txtbxSkill4.Text,
                Skill5 = txtbxSkill5.Text,
                Skill6 = txtbxSkill6.Text,
                Tertiary = txtbxTertiary.Text,
                Secondary = txtbxSecondary.Text,
                Elementary = txtbxElem.Text,
                Achievement1 = txtbxAchieve1.Text,
                Achievement2 = txtbxAchieve2.Text,
                Achievement3 = txtbxAchieve3.Text,
            };
            string json = JsonConvert.SerializeObject(r1, Formatting.Indented);
            File.WriteAllText(@"C:\Users\DELL\Desktop\JAY ANNE\PUP\2ND SEM\OBJECT PROG\JSON\Resume.json", json);
            applicants.Add(r1);

        }
        class Resume
        {
            public string Name;
            public string Number;
            public string Email;
            public string Address;
            public string Introduction;
            public string Birthday;
            public string Father;
            public string FatherOccupation;
            public string Mother;
            public string MotherOccupation;
            public string Skill1;
            public string Skill2;
            public string Skill3;
            public string Skill4;
            public string Skill5;
            public string Skill6;
            public string Tertiary;
            public string Secondary;
            public string Elementary;
            public string Achievement1;
            public string Achievement2;
            public string Achievement3;
        }
    }
}