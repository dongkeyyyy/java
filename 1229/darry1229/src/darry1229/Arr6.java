 package darry1229;

public class Arr6 {

	public static void main(String[] args) {
		int arr[][] = {
				{1,2},
				{2,4},
				{3,6},
				{4,8},
				{5,10}};
		
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j< arr[i].length; j++) {    //  arr[i].length = �࿡ ���� ���̹Ƿ� 2�� ���� ���� �� 
				System.out.printf("arr[%d][%d]=%d" + "\t",i, j, arr[i][j]);
			}
			System.out.println();
		}
		
		
		

	}

}