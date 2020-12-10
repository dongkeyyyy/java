import java.util.Scanner;

public class Input1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// Scanner 객체(s) 생성 
		Scanner s = new Scanner(System.in);
		System.out.println("이름 입력ㅣ ");
		// 키보드로 문자열 입력받음
		String name = s.nextLine();
		// 정수 입력 받음
		System.out.print("나이 입력: ");
		int age = s.nextInt();
		
		System.out.println("이름 정보: " + name);
		System.out.println("나이 정보: " + age);
		s.close();
	}

}
