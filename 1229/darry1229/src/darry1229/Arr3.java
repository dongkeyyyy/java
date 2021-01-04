package darry1229;

public class Arr3 {

	public static void main(String[] args) {
		int arr[][] = {
				{ 1, 2, 3 },  //1행
				{ 4, 5, 6 },  //2행
				{ 7, 8, 9 },  //3행
				{ 10, 11, 12 }  //4행
		};    // 1열 2열 3열
		
		for (int i = 0; i < 4; i++) {
			for (int j=0; j<3; j++) {
				System.out.print(arr[i][j]+"\t");
			}
			System.out.println();
		}
		
		//불규칙적인 행열 사용할때 arr.length
		int[][] arr2 = {
				{1, 2, 3,},
				{4, 5},
				{6, 7, 8},
				{9}};
		for (int i = 0; i < arr2.length; i++) {   //행
			for (int j=0; j<arr2[i].length; j++) {  //arr2[i].length 행에 대한 열 표시
				System.out.print(arr2[i][j]+"\t");
			}
			System.out.println();
		}
	}

}
