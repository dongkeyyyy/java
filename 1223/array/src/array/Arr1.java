package array;

import java.util.Scanner;

public class Arr1 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int[] arr = new int[3];
		int hap = 0;

		for (int i = 0; i < 3; i++) {
			System.out.print((i + 1) + "��° ���� �Է� :");
			arr[i] = s.nextInt();
		}

		for (int i = 0; i < 3; i++) { // �ݺ����� �̿��� �迭�� ��
			hap += arr[i]; // hap = hap + arr[i]
		}
		System.out.println("�迭�� �� : " + hap);

		s.close();
		// �迭�� ũ��� 1���� �����Ƿ� 3������ �������� 0���� �����Ƿ� �ִ밡 2�̴�.
	}

}
