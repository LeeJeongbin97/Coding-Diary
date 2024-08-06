using System;

public class Example
{
    public static void Main()
    {
        String[] s; // String 배열 s 선언

        Console.Clear(); // 화면 비우기
        s = Console.ReadLine().Split(' '); // 사용자로부터 입력을 받아 공백을 기준으로 문자열을 나눠서 배열 s에 저장

        int a = Int32.Parse(s[0]); // 배열 s의 첫 번째 요소를 정수로 변환하여 변수 a에 저장
        int b = Int32.Parse(s[1]); // 배열 s의 두 번째 요소를 정수로 변환하여 변수 b에 저장

        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
    }
}
