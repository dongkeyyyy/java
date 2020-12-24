package array;

public class Arr3 {

	public static void main(String[] args) {
		int score[] = {10, 20, 30, 40, 50}; 
		System.out.println("배열시작위치 : " + score);  // 결과값은 [I@1e965684 라고 나오는데 이건 주소값
		System.out.println("배열 크기 : " + score.length);
		
		for (int i = 0; i<score.length; i++) {
			System.out.println(score[i]);
		}
	}
}
