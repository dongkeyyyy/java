package darry1229;

public class Arr3 {

	public static void main(String[] args) {
		int arr[][] = {
				{ 1, 2, 3 },  //1��
				{ 4, 5, 6 },  //2��
				{ 7, 8, 9 },  //3��
				{ 10, 11, 12 }  //4��
		};    // 1�� 2�� 3��
		
		for (int i = 0; i < 4; i++) {
			for (int j=0; j<3; j++) {
				System.out.print(arr[i][j]+"\t");
			}
			System.out.println();
		}
		
		//�ұ�Ģ���� �࿭ ����Ҷ� arr.length
		int[][] arr2 = {
				{1, 2, 3,},
				{4, 5},
				{6, 7, 8},
				{9}};
		for (int i = 0; i < arr2.length; i++) {   //��
			for (int j=0; j<arr2[i].length; j++) {  //arr2[i].length �࿡ ���� �� ǥ��
				System.out.print(arr2[i][j]+"\t");
			}
			System.out.println();
		}
	}

}
