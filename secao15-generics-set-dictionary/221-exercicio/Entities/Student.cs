namespace _221_exercicio.Entities
{
    internal class Student
    {
        public int Registration { get; set; }

        public Student(int registration)
        {
            Registration = registration;
        }

        public override int GetHashCode()
        {
            return Registration.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is Student))
                return false;

            Student other = (Student)obj;
            return Registration.Equals(other.Registration);
        }
    }
}
