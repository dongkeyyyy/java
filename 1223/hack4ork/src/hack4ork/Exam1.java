package hack4ork;

public class Exam1 {

	public static void main(String[] args) {
		int arr[] = { 20, 34, 22, 14, 36, 23, 67, 25, 99, 88 };
		double hap = 0;

		for (int i = 0; i < arr.length; i++) {
			hap += arr[i];
		}
		System.out.println("1차원 배열의 합을 구하시오:" + hap);
		System.out.println("1차원 배열의 평균을 구하시오" + hap/arr.length);

	}

}
