class Program {
  public static List<Scholar> scholars = new List<Scholar>();
  public static List<Student> students = new List<Student>();
  public static List<Teacher> teachers = new List<Teacher>();
  

  public static void Main(string[] args) {

    bool isAuthenticated = false;

    while (true) {
      showMenu(isAuthenticated);
      isAuthenticated = getInput(isAuthenticated);
    }
  }

  public static void showMenu(bool isAuthenticated) {
    if (isAuthenticated) {
      Console.WriteLine("===================================");
      Console.WriteLine("[1] Join The Event");
      Console.WriteLine("[2] Scholars list that join the event");
      Console.WriteLine("[3] Students list that join the event");
      Console.WriteLine("[4] Teachers list that join the event");
      Console.WriteLine("[5] Logout");
      Console.WriteLine("===================================");
    } else {
      Console.WriteLine("===================================");
      Console.WriteLine("[1] Register");
      Console.WriteLine("[2] Show statistics");
      Console.WriteLine("[3] Login");
      Console.WriteLine("===================================");
    }
  }

  public static bool getInput(bool isAuthenticated) {
    Console.WriteLine("Enter your choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    if (isAuthenticated) {
      switch (choice) {
        case 1:
          Console.WriteLine("Join The Event");
          Console.Clear();
          return true;
        case 2:
          Console.WriteLine("Scholars list that join the event");
          Console.Clear();
          return true;
        case 3:
          Console.WriteLine("Students list that join the event");
          Console.Clear();
          return true;
        case 4:
          Console.WriteLine("Teachers list that join the event");
          Console.Clear();
          return true;
        case 5:
          Console.WriteLine("Logout");
          Console.Clear();
          return false;
        default:
          Console.WriteLine("Invalid choice");
          Console.Clear();
          return false;
      }
    } else {
      switch (choice) {
        case 1:
          Console.WriteLine("Register");
          register();
          Console.Clear();
          return false;
        case 2:
          Console.WriteLine("Show statistics");
          Console.Clear();
          return false;
        case 3:
          Console.WriteLine("Login");
          Console.Clear();
          return LoginMenu.login(scholars, teachers);
        default:
          Console.WriteLine("Invalid choice");
          Console.Clear();
          return false;
      }
    }
  }

  public static void register() {
    int joinerType = Reader.readJoinerType();
    switch (joinerType) {
      case 1:
        Console.WriteLine("Scholar");
        Scholar scholar = RegisterMenu.registerScholar(scholars, students, teachers);
        if (scholar != null) {
          scholars.Add(scholar);
        }
        break;
      case 2:
        Console.WriteLine("Student");
        Student student = RegisterMenu.registerStudent(scholars, students, teachers);
        if (student != null) {
          students.Add(student);
        }
        break;
      case 3:
        Console.WriteLine("Teacher");
        Teacher teacher = RegisterMenu.registerTeacher(scholars, students, teachers);
        if (teacher != null) {
          teachers.Add(teacher);
        }
        break;
      default:
        Console.WriteLine("Invalid choice");
        break;
    }
  }



}