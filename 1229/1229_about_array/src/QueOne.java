import java.util.Scanner;

public class QueOne {

	public static void main(String[] args) {
		// 내가정한 숫자만큼의 숫자들을 입력받고
		// 그 중에서 최솟값과 최댓값을 출력하는 것

		// 1. 총 몇개의 숫자를 입력받을지 정함
		System.out.println("숫자를 입력 받으세요.");
		int countNum = 0;
		Scanner s = new Scanner(System.in);
		countNum = s.nextInt();

		// 2. 내가 입력한 숫자크기의 배열을 선언
		int[] input = new int[countNum];

		// 3. 그 배열에다가 숫자를 집어넣음
		for (int i = 0; i < input.length; i++) {
			input[i] = s.nextInt();
		}

		// 최댓값과 최솟값을 저장할 변수를 만듦
		int max = input[0];
		int min = input[0];
		for (int i = 0; i < input.length; i++) {
			if (max < input[i]) {
				max = input[i];
			}
			if (min > input[i]) {
				min = input[i];
			}

		}

		System.out.println(max);
		System.out.println(min);
		s.close();
		// 4. 그 배열 안에서 가장 큰값과 가장 작은 값을 출력

	}

}
