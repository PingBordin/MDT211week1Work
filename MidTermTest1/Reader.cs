
public class Reader {

    public static int readJoinerType() {
        Console.WriteLine("Choose joiner type: ");
        Console.WriteLine("[1] นักศึกษาปัจจุบัน");
        Console.WriteLine("[2] นักเรียน");
        Console.WriteLine("[3] อาจารย์");

        int joinerType = Convert.ToInt32(Console.ReadLine());

        if (joinerType != 1 && joinerType != 2 && joinerType != 3) {
            Console.WriteLine("Invalid joiner type.");
            return readJoinerType();
        }

        return joinerType;
    }

    public static string readPrefix() {
        Console.WriteLine("Choose prefix (): ");
        Console.WriteLine("[1]: นาย");
        Console.WriteLine("[2]: นาง");
        Console.WriteLine("[3]: นางสาว");

        int prefix = int.Parse(Console.ReadLine());
        if (prefix != 1 && prefix != 2 && prefix != 3) {
            Console.WriteLine("Invalid prefix");
            return readPrefix();
        }

        return prefix == 1 ? "นาย" : prefix == 2 ? "นาง" : "นางสาว";
    }

    public static string readFirstname() {
        Console.WriteLine("enter firstname: ");

        string firstname = Console.ReadLine();

        if (firstname.Length == 0) {
            Console.WriteLine("Firstname must be at least 0 characters");
            return readFirstname();
        }

        return firstname;
    }

    public static string readLastname() {
        Console.WriteLine("enter lastname: ");

        string lastname = Console.ReadLine();

        if (lastname.Length == 0) {
            Console.WriteLine("Lastname must be at least 0 characters");
            return readLastname();
        }

        return lastname;
    }

    public static int readAge() {
        Console.WriteLine("enter age: ");

        int age = int.Parse(Console.ReadLine());

        if (age < 0) {
            Console.WriteLine("Age must be at least 0");
            return readAge();
        }

        return age;
    }

    public static string readGrade() {
        Console.WriteLine("choose grade: ");
        Console.WriteLine("[1]: มัธยมศึกษาปีที่ 4");
        Console.WriteLine("[2]: มัธยมศึกษาปีที่ 5");
        Console.WriteLine("[3]: มัธยมศึกษาปีที่ 6");

        int grade = int.Parse(Console.ReadLine());

        if (grade != 1 && grade != 2 && grade != 3) {
            Console.WriteLine("Invalid grade");
            return readGrade();
        }

        return grade == 1 ? "มัธยมศึกษาปีที่ 4" : grade == 2 ? "มัธยมศึกษาปีที่ 5" : "มัธยมศึกษาปีที่ 6";
    }

    public static string readAllergy() {
        Console.WriteLine("enter allergy: ");

        string allergy = Console.ReadLine();

        if (allergy?.Length == 0) {
            Console.WriteLine("Allergy must be at least 0 characters");
            return readAllergy();
        }

        return allergy;
    }

    public static string readReligion() {
        Console.WriteLine("choose religion: ");
        Console.WriteLine("[1]: พุทธ");
        Console.WriteLine("[2]: คริสต์");
        Console.WriteLine("[3]: อิสลาม");

        int religion = int.Parse(Console.ReadLine());

        if (religion != 1 && religion != 2 && religion != 3) {
            Console.WriteLine("Invalid religion");
            return readReligion();
        }

        return religion == 1 ? "พุทธ" : religion == 2 ? "คริสต์" : "อิสลาม";
    }

    public static string readSchool() {
        Console.WriteLine("enter school: ");

        string school = Console.ReadLine();

        if (school.Length == 0) {
            Console.WriteLine("School must be at least 0 characters");
            return readSchool();
        }

        return school;
    }

    public static int readId() {
        Console.WriteLine("enter id: ");

        int id = int.Parse(Console.ReadLine());

        if (id < 0) {
            Console.WriteLine("Id must be at least 0");
            return readId();
        }

        return id;
    }

    public static bool readIsAdminstrator() {
        Console.WriteLine("Is administrator? (y/n): ");

        string isAdminstrator = Console.ReadLine();

        if (isAdminstrator != "y" && isAdminstrator != "n") {
            Console.WriteLine("Invalid input");
            return readIsAdminstrator();
        }

        return isAdminstrator == "y";
    }

    public static string readPassword() {
        Console.WriteLine("enter password: ");

        string password = Console.ReadLine();

        if (password.Length == 0) {
            Console.WriteLine("Password must be at least 0 characters");
            return readPassword();
        }

        return password;
    }

    public static string readEmail() {
        Console.WriteLine("enter email: ");

        string email = Console.ReadLine();

        if (email.Length == 0) {
            Console.WriteLine("Email must be at least 0 characters");
            return readEmail();
        }

        return email;
    }

    public static bool readHaveCarOrNot() {
        Console.WriteLine("Have car? (y/n): ");

        string haveCar = Console.ReadLine();

        if (haveCar != "y" && haveCar != "n") {
            Console.WriteLine("Invalid input");
            return readHaveCarOrNot();
        }

        return haveCar == "y";
    }

    public static string readCarRegistration() {
        Console.WriteLine("enter car registration: ");

        string carRegistration = Console.ReadLine();

        if (carRegistration.Length == 0) {
            Console.WriteLine("Car registration must be at least 0 characters");
            return readCarRegistration();
        }

        return carRegistration;
    }

    public static string readPosition() {
        Console.WriteLine("choose position: ");
        Console.WriteLine("[1]: คณบดี");
        Console.WriteLine("[2]: หัวหน้าภาควิชา");
        Console.WriteLine("[3]: อาจารย์ประจำ");

        int position = int.Parse(Console.ReadLine());

        if (position != 1 && position != 2 && position != 3) {
            Console.WriteLine("Invalid position");
            return readPosition();
        }

        return position == 1 ? "คณบดี" : position == 2 ? "หัวหน้าภาควิชา" : "อาจารย์ประจำ";
    }

}
