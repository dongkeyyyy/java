package array;

public class Arr4 {

	public static void main(String[] args) {
		int arr[] = new int[10]; // int형으로 크기 10인 0으로 비어 있는 배열 생성

		for (int i = 0; i < arr.length; i++) { // i<arr.length 로 쓰거나 i<10으로 표기해도됨
			arr[i] = i;

		} // 중괄호 안에서 선언된 변수는 중괄호 밖에 까지는 영향을 미치지 않는다. 그래서 위의 포문과 아래의 포문에서 i를 사용해도 상관이 없다

		for (int i = 0; i < arr.length; i++) {
			System.out.println(arr[i]);
		}
	}
}
