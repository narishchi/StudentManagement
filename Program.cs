namespace StudentManagement
{
    public class Program
    {
        // จุดเริ่มต้นของโปรแกรม
        [STAThread]
        static void Main()
        {
            // ตั้งค่าให้ใช้การแสดงผลในรูปแบบของ Windows Forms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // เรียกใช้ Form1 ที่เราสร้างไว้
        }
    }
}