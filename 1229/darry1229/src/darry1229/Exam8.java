package darry1229;

public class Exam8 {

	public static void main(String[] args) {
		int tto[] = new int[6];
		System.out.println("--------------------");
		System.out.println("간단한 로또 프로그램 v1.1");
		System.out.println("--------------------");
		for (int i = 0; i < 6; i++) {
			int lotto = (int) (Math.random() * 45) + 1;
			System.out.println("로또 번호 : " + lotto);
			tto[i] = lotto;
			if (i == 0) {
				tto[i] = lotto;

			} else {
				tto[i] = lotto;
				for (int j = 0; j < i; j++) {
					if (tto[j] == tto[i]) {
						System.out.println("중복 발생");
						i--;
						break;
					}
				}
			}

		}
		for (int i = 0; i < 6; i++) {
			System.out.print(tto[i] + "   ");
		}
	}
}