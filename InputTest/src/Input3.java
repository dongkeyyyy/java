import java.util.Scanner;

public class Input3 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.println("����Ÿ� �Է�: ");
		double juhang = s.nextDouble();
		System.out.println("����� �ֹ��� �� �Է�: ");
		double fuels = s.nextDouble();
		// ���� ����
		double yeonbi = juhang / fuels;
		System.out.println("��� ����: " + yeonbi);
		s.close();
	}

}
