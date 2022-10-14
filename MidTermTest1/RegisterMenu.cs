public class RegisterMenu {

    public static Scholar registerScholar(
        List<Scholar> existingScholars,
        List<Student> existingStudents,
        List<Teacher> existingTeachers
    ) {
        Scholar scholar = new Scholar();
        scholar.prefix = Reader.readPrefix();
        scholar.firstName = Reader.readFirstname();
        scholar.lastName = Reader.readLastname();
        scholar.id = Reader.readId();
        scholar.age = Reader.readAge();
        scholar.allergy = Reader.readAllergy();
        scholar.religion = Reader.readReligion();
        scholar.isAdminstrator = Reader.readIsAdminstrator();

        if (scholar.isAdminstrator) {
            scholar.email = Reader.readEmail();
            scholar.password = Reader.readPassword();
        }

        foreach (Scholar existingScholar in existingScholars) {
            if (
                existingScholar.prefix == scholar.prefix &&
                existingScholar.firstName == scholar.firstName &&
                existingScholar.lastName == scholar.lastName
            ) {
                Console.WriteLine("Person already exists");
                return null;
            }

            if (existingScholar.email == scholar.email) {
                Console.WriteLine("Email already exists");
                return null;
            }
        }

        foreach (Student existingStudent in existingStudents) {
            if (
                existingStudent.prefix == scholar.prefix &&
                existingStudent.firstname == scholar.firstName &&
                existingStudent.lastname == scholar.lastName
            ) {
                Console.WriteLine("Person already exists");
                return null;
            }

            if (existingStudent.email == scholar.email) {
                Console.WriteLine("Email already exists");
                return null;
            }
        }

        foreach (Teacher existingTeacher in existingTeachers) {
            if (
                existingTeacher.prefix == scholar.prefix &&
                existingTeacher.firstname == scholar.firstName &&
                existingTeacher.lastname == scholar.lastName
            ) {
                Console.WriteLine("Person already exists");
                return null;
            }

            if (existingTeacher.email == scholar.email) {
                Console.WriteLine("Email already exists");
                return null;
            }
        }
        return scholar;
    }

    public static Student registerStudent(
        List<Scholar> existingScholars,
        List<Student> existingStudents,
        List<Teacher> existingTeachers
    ) {
        Student student = new Student();
        student.prefix = Reader.readPrefix();
        student.firstname = Reader.readFirstname();
        student.lastname = Reader.readLastname();
        student.age = Reader.readAge();
        student.grade = Reader.readGrade();
        student.allergy = Reader.readAllergy();
        student.religion = Reader.readReligion();
        student.school = Reader.readSchool();

        foreach (Scholar existingScholar in existingScholars) {
            if (
                existingScholar.prefix == student.prefix &&
                existingScholar.firstName == student.firstname &&
                existingScholar.lastName == student.lastname
            ) {
                Console.WriteLine("Person already exists");
                return null;
            }

            if (existingScholar.email == student.email) {
                Console.WriteLine("Email already exists");
                return null;
            }
        }

        foreach (Student existingStudent in existingStudents) {
            if (
                existingStudent.prefix == student.prefix &&
                existingStudent.firstname == student.firstname &&
                existingStudent.lastname == student.lastname
            ) {
                Console.WriteLine("Person already exists");
                return null;
            }

            if (existingStudent.email == student.email) {
                Console.WriteLine("Email already exists");
                return null;
            }
        }

        foreach (Teacher existingTeacher in existingTeachers) {
            if (
                existingTeacher.prefix == student.prefix &&
                existingTeacher.firstname == student.firstname &&
                existingTeacher.lastname == student.lastname
            ) {
                Console.WriteLine("Person already exists");
                return null;
            }

            if (existingTeacher.email == student.email) {
                Console.WriteLine("Email already exists");
                return null;
            }
        }

        return student;
    }

    public static Teacher registerTeacher(
        List<Scholar> existingScholars,
        List<Student> existingStudents,
        List<Teacher> existingTeachers
    ) {
        Teacher teacher = new Teacher();

        teacher.prefix = Reader.readPrefix();
        teacher.firstname = Reader.readFirstname();
        teacher.lastname = Reader.readLastname();
        teacher.age = Reader.readAge();
        teacher.position = Reader.readPosition();
        teacher.allergy = Reader.readAllergy();
        teacher.religion = Reader.readReligion();
        teacher.haveCarOrNot = Reader.readHaveCarOrNot();

        if (teacher.haveCarOrNot) {
            teacher.carRegistration = Reader.readCarRegistration();
        }

        teacher.isAdminstrator = Reader.readIsAdminstrator();
        if (teacher.isAdminstrator) {
            teacher.email = Reader.readEmail();
            teacher.password = Reader.readPassword();
        }

        foreach (Scholar existingScholar in existingScholars) {
            if (
                existingScholar.prefix == teacher.prefix &&
                existingScholar.firstName == teacher.firstname &&
                existingScholar.lastName == teacher.lastname
            ) {
                Console.WriteLine("Person already exists");
                return null;
            }

            if (existingScholar.email == teacher.email) {
                Console.WriteLine("Email already exists");
                return null;
            }
        }

        foreach (Student existingStudent in existingStudents) {
            if (
                existingStudent.prefix == teacher.prefix &&
                existingStudent.firstname == teacher.firstname &&
                existingStudent.lastname == teacher.lastname
            ) {
                Console.WriteLine("Person already exists");
                return null;
            }

            if (existingStudent.email == teacher.email) {
                Console.WriteLine("Email already exists");
                return null;
            }
        }

        foreach (Teacher existingTeacher in existingTeachers) {
            if (
                existingTeacher.prefix == teacher.prefix &&
                existingTeacher.firstname == teacher.firstname &&
                existingTeacher.lastname == teacher.lastname
            ) {
                Console.WriteLine("Person already exists");
                return null;
            }

            if (existingTeacher.email == teacher.email) {
                Console.WriteLine("Email already exists");
                return null;
            }
        }

        return teacher;
    }
}
