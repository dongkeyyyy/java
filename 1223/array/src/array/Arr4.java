package array;

public class Arr4 {

	public static void main(String[] args) {
		int arr[] = new int[10]; // int������ ũ�� 10�� 0���� ��� �ִ� �迭 ����

		for (int i = 0; i < arr.length; i++) { // i<arr.length �� ���ų� i<10���� ǥ���ص���
			arr[i] = i;

		} // �߰�ȣ �ȿ��� ����� ������ �߰�ȣ �ۿ� ������ ������ ��ġ�� �ʴ´�. �׷��� ���� ������ �Ʒ��� �������� i�� ����ص� ����� ����

		for (int i = 0; i < arr.length; i++) {
			System.out.println(arr[i]);
		}
	}
}
