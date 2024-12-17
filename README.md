##Calculator
By Thiradet Prasarsuk , 673450195-4 , Computer and Infomation Science, KKU

##การรับและการแสดงผลข้อมูล
รับข้อมูลจากผู้ใช้งาน และทำงานผ่านการกดปุ่มเพื่อคำนวนตัวเลข
ปุ่มบวก
private void button1_Click(object sender, EventArgs e)
{
    // ข้อความตัวอักษร
    string inputNum1 = num1.Text;
    string inputNum2 = num2.Text;
    // convert string to number (integer)
    int iNum1 = Int32.Parse(inputNum1);
    int iNum2 = Int32.Parse(inputNum2);
    // int ทำให้เราสามารถทำการ + - * / ได้
    int iResult = iNum1 + iNum2;
    // ที่ตัวแปรชื่อ result
    // มีคุณสมบัติชื่อ Text
    result.Text = iResult.ToString();
}
รับข้อมูล
ตัวอย่าง

 string inputNum1 = num1.Text;
 string inputNum2 = num2.Text;
แปลงชนิดของข้อมูล
ตัวอย่าง

double iNum1 = double.Parse(inputNum1);
double iNum2 = double.Parse(inputNum2);
คำนวนผลลัพท์
ตัวอย่าง

double iResuit = iNum1 - iNum2;
แสดงผล
ตัวอย่าง

result.Text = iResuit.ToString();
ปุ่มลบ
private void button3_Click(object sender, EventArgs e)
{
    string inputNum1 = num1.Text;
    string inputNum2 = num2.Text;
    // convert str to double
    double iNum1 = double.Parse(inputNum1);
    double iNum2 = double.Parse(inputNum2);
    double iResuit = iNum1 - iNum2; // ฟังก์ชั่น -
    result.Text = iResuit.ToString(); // .ToString() แปลงกลับเป็น str
}


ปุ่มคูณ
```
 private void button4_Click(object sender, EventArgs e)
 {

     string inputNum1 = num1.Text;
     string inputNum2 = num2.Text;
     // convert str to double
     double iNum1 = double.Parse(inputNum1);
     double iNum2 = double.Parse(inputNum2);
     double iResuit = iNum1 * iNum2; // ฟังก์ชั่น *
     result.Text = iResuit.ToString();// .ToString() แปลงกลับเป็น str
 }

```

ปุ่มหาร
```
 private void button5_Click(object sender, EventArgs e)
 {
     string inputNum1 = num1.Text;
     string inputNum2 = num2.Text;
     // convert str to double
     double iNum1 = double.Parse(inputNum1);
     double iNum2 = double.Parse(inputNum2);
     double iResuit = iNum1 / iNum2; // ฟังก์ชั่น /
     result.Text = iResuit.ToString();// .ToString() แปลงกลับเป็น str
 }
```




ปุ่มลบข้อมูล
```
private void button6_Click(object sender, EventArgs e)
{
    //ล้างข้อความใน Textbox
    num1.Text = "";
    num2.Text = "";
    result.Text = "";
}
```
