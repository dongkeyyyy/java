package operTest_1208;

import java.util.Scanner;

public class Homework {

	public static void main(String[] args) {
		int a = 0; // 500��
		int b = 0; // 100��
		int c = 0; // 50��
		int d = 0; // 10��
		
		System.out.println("��ȯ�� �ݾ� : ");
		
		Scanner s = new Scanner(System.in);
		int e = s.nextInt(); // ���� ��ȯ��  �ݾ�
		
		a = 500;  b = 100;  c = 50;   d = 10;
		
		int num1 = e / a; 
		int num2 = (e % a) / b;
		int num3 = (e % a % b) / c;
		int num4 = (e % a % b % c) / d;
		int num5 = e % a % b % c % d;
		
		System.out.println("----------------------------");
		System.out.println("    ���� ��ȯ�� ���α׷� 1.0     ");
		System.out.println("----------------------------");
		System.out.println("  ����� ���� : " + num1 + "��"  );
		System.out.println("   ��� ���� : " + num2 + "��"  );
		System.out.println("  ���ʿ� ���� : " + num3 + "��" );
		System.out.println("  �ʿ� ���� : " + num4 + "��"   );
		System.out.println("�ٲ��� ���� �ܵ� : " + num5 + "��");
		System.out.println("----------------------------");
		
		
		
		
		

	}

}
