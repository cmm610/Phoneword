using System;
using System.Collections.Generic;
namespace Phoneword {
	public class DisneyTest {
		private string[,] questions = {
			{"expend energy, enjoy groups", "conserve energy, enjoy one-on-one"},
			{"interpret literally", "look for meaning and possibilities"},
			{"logical, thinking, questioning", "empathetic, feeling, accommodating"},
			{"organized, orderly", "flexible, adaptable"},
			{"more outgoing, think out loud", "more reserved, think to yourself"},
			{"practical, realistic, experiential", "imaginative, innovative, theoretical"},
			{"candid, straight forward, frank", "tactful, kind, encouraging"},
			{"plan, schedule", "unplanned, spontaneous"},
			{"seek many tasks, public activities, interaction with others", "seek private, solitary activities with quiet to concentrate"},
			{"standard, usual, conventional", "different, novel, unique"},
			{"firm, tend to criticize, hold the line", "gentle, tend to appreciate, conciliate"},
			{"regulated, structured", "easygoing, “live” and “let live”"},
			{"external, communicative, express yourself", "internal, reticent, keep to yourself"},
			{"focus on here-and-now", "look to the future, global perspective, “big picture”"},
			{"tough-minded, just", "tender-hearted, merciful"},
			{"preparation, plan ahead", "go with the flow, adapt as you go"},
			{"active, initiate", "reflective, deliberate"},
			{"facts, things, “what is”", "ideas, dreams, “what could be,” philosophical"},
			{"matter of fact, issue-oriented", "sensitive, people-oriented, compassionate"},
			{"control, govern", "latitude, freedom"},
		};
		private int[,] questionMap = new int[4, 5]{
				{0,4,8,12,16},
				{1,5,9,13,17},
				{2,6,10,14,18},
				{3,7,11,15,19},
			};

		private string[,] letterMap = {
			{"E","I"},
			{"S","N"},
			{"T","F"},
			{"J","P"}
		};

		private Dictionary<string, string[]> characterMap = new Dictionary<string, string[]> {
			{"ESTJ", new string[] {"Bagheera", "Woody"}},
			{"ISTJ", new string[] {"Zazu", "Sebastian"}},
			{"ESFJ", new string[] {"Snow White", "Aurora"}},
			{"ISFJ", new string[] {"Jimini Cricket", "Marlin"}},
			{"ESTP", new string[] {"Flynn Rider", "Dodger"}},
			{"ISTP", new string[] {"Tinker Bell", "Flik"}},
			{"ESFP", new string[] {"Timon", "Mushu"}},
			{"ISFP", new string[] {"Pumbaa", "Roger Radcliff"}},
			{"ENFJ", new string[] {"Mufasa", "Merlin"}},
			{"INFJ", new string[] {"Pocahontas", "Mulan"}},
			{"ENFP", new string[] {"Ariel", "Aladdin"}},
			{"INFP", new string[] {"Chicken Little", "Carl"}},
			{"ENTJ", new string[] {"Shang", "Buzz Lightyear"}},
			{"INTJ", new string[] {"Basil", "Milo"}},
			{"ENTP", new string[] {"Robin Hood", "Jack"}},
			{"INTP", new string[] {"Owl", "Maurice"}}
		};

		public static string[,] getQuestions() {
			return questions;
		}

		public static int[,] getQuestionMap() {
			return questionMap;
		}

		public static Dictionary<string, string[]> getCharacterMap() {
			return characterMap;
		}
	}
}
