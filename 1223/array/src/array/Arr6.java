package array;

public class Arr6 {

	public static void main(String[] args) {
		// 향상된 for 문
		int arr[] = { 10, 20, 30 };
		for (int i : arr) {
			System.out.println(i); // 배열에서 30까지 있으므로 마지막 30 입력 후 자동으로 반복문이 종료가 됨
		}
	}
}
