package darry1229;

public class Arr8 {

	public static void main(String[] args) {

		int arr[][] = new int[10][10];
		int arr2[][] = new int [8][9];
		for (int i = 1; i < arr.length; i++) {
			for (int j = 2; j < arr[i].length; j++) {
				arr2[j-2][i-1] = i * j;
				System.out.printf("%d*%d=%d" + "\t", j, i, i * j);
			}
			System.out.println();
		}
	}
	// ���⼭ ������ ����ɶ� ��������� arr2 ������ �迭�� ��� �����ϴ���?
}
