import java.util.Scanner;

public class Input1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// Scanner ��ü(s) ���� 
		Scanner s = new Scanner(System.in);
		System.out.println("�̸� �Է¤� ");
		// Ű����� ���ڿ� �Է¹���
		String name = s.nextLine();
		// ���� �Է� ����
		System.out.print("���� �Է�: ");
		int age = s.nextInt();
		
		System.out.println("�̸� ����: " + name);
		System.out.println("���� ����: " + age);
		s.close();
	}

}
