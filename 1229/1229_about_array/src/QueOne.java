import java.util.Scanner;

public class QueOne {

	public static void main(String[] args) {
		// �������� ���ڸ�ŭ�� ���ڵ��� �Է¹ް�
		// �� �߿��� �ּڰ��� �ִ��� ����ϴ� ��

		// 1. �� ��� ���ڸ� �Է¹����� ����
		System.out.println("���ڸ� �Է� ��������.");
		int countNum = 0;
		Scanner s = new Scanner(System.in);
		countNum = s.nextInt();

		// 2. ���� �Է��� ����ũ���� �迭�� ����
		int[] input = new int[countNum];

		// 3. �� �迭���ٰ� ���ڸ� �������
		for (int i = 0; i < input.length; i++) {
			input[i] = s.nextInt();
		}

		// �ִ񰪰� �ּڰ��� ������ ������ ����
		int max = input[0];
		int min = input[0];
		for (int i = 0; i < input.length; i++) {
			if (max < input[i]) {
				max = input[i];
			}
			if (min > input[i]) {
				min = input[i];
			}

		}

		System.out.println(max);
		System.out.println(min);
		s.close();
		// 4. �� �迭 �ȿ��� ���� ū���� ���� ���� ���� ���

	}

}
