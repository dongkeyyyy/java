package looptest1222;

import java.util.Scanner;

public class Exam3 {

	public static void main(String[] args) {
		System.out.println("--------------------------------");
		System.out.println("�Է¹޴� ���� ���� ���ϴ� ���α׷� v1.0");
		System.out.println("--------------------------------");
		Scanner s = new Scanner(System.in);
		System.out.println("1.Num1 �Է�=>");
		int num1 = s.nextInt();
		System.out.println("2.Num2 �Է�=>");
		int num2 = s.nextInt();
		int hap = 0;
		
		if (num2 > num1) {
			System.out.println("num2�� ���� Ů�ϴ�.");
			// ���α׷� ���� ����
			System.exit(0);
		}
		
		for (int i=num1; i<=num2; i++) {
			hap += i;	
		}
		
		System.out.printf("%d ~ %d ������ �� : %d\n", num1, num2, hap);

		s.close();
	}

}
