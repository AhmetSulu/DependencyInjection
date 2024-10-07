using DependencyInjection;

public class Program
{
    static void Main(string[] args)
    {
        ITeacher teacher = new Teacher("Sertan", "Bozkuş");
        ClassRoom classRoom = new ClassRoom(teacher);
        classRoom.GetTeacherInfo();
    }
}