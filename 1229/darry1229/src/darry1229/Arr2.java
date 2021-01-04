package darry1229;



public class Arr2 {

	public static void main(String[] args) {
		int arr[][] = new int[4][3];
		int value = 1;

		for (int i = 0; i < 4; i++) {
			for (int j = 0; j < 3; j++) {
				arr[i][j] = value++;
				System.out.println("디버깅 : " + arr[i][j]);
			}
		}
		for (int i = 0; i < 4; i++) {
			for (int j = 0; j < 3; j++) {
				System.out.print(arr[i][j]+"\t"); //  "\t"는 tab 키와 동일
			}
			System.out.println();
		}

	}

}
