package darry1229;

public class Exam8 {

	public static void main(String[] args) {
		int tto[] = new int[6];
		System.out.println("--------------------");
		System.out.println("������ �ζ� ���α׷� v1.1");
		System.out.println("--------------------");
		for (int i = 0; i < 6; i++) {
			int lotto = (int) (Math.random() * 45) + 1;
			System.out.println("�ζ� ��ȣ : " + lotto);
			tto[i] = lotto;
			if (i == 0) {
				tto[i] = lotto;

			} else {
				tto[i] = lotto;
				for (int j = 0; j < i; j++) {
					if (tto[j] == tto[i]) {
						System.out.println("�ߺ� �߻�");
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