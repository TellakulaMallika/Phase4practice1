using SchoolLib;
namespace TestProjectPhase4practice1
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void StudentConstructor_ValidInputs_PropertiesSetCorrectly()
        {
            int id = 1;
            string name = "Mallika";
            string address = "Guntakal";
            string email = "xyz@gmail.com";
            int marks = 85;
            string className = "10A";

            var student = new Student
            {
                ID = id,
                Name = name,
                Address = address,
                Email = email,
                Marks = marks,
                ClassName = className

            };
            Assert.AreEqual(id, student.ID);
            Assert.AreEqual(name, student.Name);
            Assert.AreEqual(address, student.Address);
            Assert.AreEqual(email, student.Email);
            Assert.AreEqual(marks, student.Marks);
            Assert.AreEqual(className, student.ClassName);
        }
        [Test]
        public void SubjectConstructor_ValidInputs_PropertiesSetCorrectly()
        {
            int subjectId = 101;
            string subjectName = "Math";

            var subject = new Subject
            {
                ID = subjectId,
                Name = subjectName
            };
            Assert.AreEqual(subjectId, subject.ID);
            Assert.AreEqual(subjectName, subject.Name);


        }
        [Test]
        public void ClassConstructor_validInputs_PropertiesSetCorrectly()
        {
            int classId = 201;
            string className = "10A";
            var schoolClass = new Class
            {
                ID = classId,
                Name = className

            };
            Assert.AreEqual(classId, schoolClass.ID);
            Assert.AreEqual(className, schoolClass.Name);
        }
    }
}