package hack4ork;

public class Exam3 {

	public static void main(String[] args) {
		int arr[] = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
		int arr2[] = new int[10];
		
		for (int i = 0; i < arr.length; i++) {
			System.out.println(arr[i]);
		}
		for (int j = 0; j<arr2.length; j++) {
			arr2[j] = arr[9-j];
			System.out.println(arr2[j]);
		}

	}

}
