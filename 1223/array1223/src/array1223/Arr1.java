package array1223;

public class Arr1 {

	public static void main(String[] args) {
		int arr[] = new int[100];
		for (int i = 0; i < arr.length; i++) {
			arr[i] = (i + 1);
			if ((i + 1) % 5 == 0) {
				System.out.println(arr[i]);
			}
			
			if (arr[i] > 89) {
				System.exit(0);
			}

		}

	}
}