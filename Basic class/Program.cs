class Program {
    void main() {
        ReportCard reportCard = new ReportCard();

        reportCard.AddNumber(5.3);
        reportCard.AddNumber(6);
        reportCard.AddNumber(9);

        reportCard.DidSucceed();
    }
}