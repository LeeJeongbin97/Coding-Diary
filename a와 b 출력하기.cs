using System;

public class Example
{
    public static void Main()
    {
        // String 배열을 선언합니다.
        String[] s;

        // 콘솔 화면을 지우고, 사용자로부터 입력을 받아 공백을 기준으로 문자열을 나눠서 배열 s에 저장합니다.
        Console.Clear();
        s = Console.ReadLine().Split(' ');

        // 배열 s의 첫 번째 요소를 정수로 변환하여 변수 a에 저장합니다.
        int a = Int32.Parse(s[0]);
        // 배열 s의 두 번째 요소를 정수로 변환하여 변수 b에 저장합니다.
        int b = Int32.Parse(s[1]);

        // 변수 a의 값을 출력합니다.
        Console.WriteLine("a = {0}", a);
        // 변수 b의 값을 출력합니다.
        Console.WriteLine("b = {0}", b);
    }
}
