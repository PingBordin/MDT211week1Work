public class LoginMenu {
    
    public static bool login(
        List<Scholar> existingScholars,
        List<Teacher> existingTeachers
    ) {
        Console.WriteLine("Welcome to the login menu!");
        Console.WriteLine("Please enter your email (type 'exit' to exit):");
        string email = Console.ReadLine();
        if (email == "exit") {
            return false;
        }

        Console.WriteLine("Please enter your password:");
        string password = Console.ReadLine();

        foreach (Scholar existingScholar in existingScholars) {
            if (existingScholar.email == email && existingScholar.password == password) {
                return true;
            }
        }

        foreach (Teacher existingTeacher in existingTeachers) {
            if (existingTeacher.email == email && existingTeacher.password == password) {
                return true;
            }
        }
        
        Console.Clear();
        return login(existingScholars, existingTeachers);
    }
}
