package looptest1222;

public class Exam2 {

	public static void main(String[] args) {
		// 1~100까지 숫자중에 5의배수만 출력하는 프로그램
		System.out.println("----------------------");
		System.out.println("5의 배수 출력 프로그램 1.0");
		System.out.println("----------------------");
		for (int i = 1; i <= 100; i++) {
			if (i % 5 == 0) {
				System.out.print(i + " ");
			}

		}

	}

}
