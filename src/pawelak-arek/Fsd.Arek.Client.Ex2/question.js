class Question {
  constructor(category, question, correct_answer, incorrect_answer) {
    this.category = category;
    this.question = question;
    this.correct_answer = correct_answer;
    this.answer = correct_answer + ',' + incorrect_answer;
  }
}