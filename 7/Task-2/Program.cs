namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Мне жаль слышать о твоей боли, но мне так жаль слышать о твоей тяжелой работе и твоей боли. Это также не так потрясающе, как бассейн. Тушь для ресниц для беременных всегда будет стильной завтра. Технология акробатики является основным компонентом обслуживания клиентов. Просто сядьте и наблюдайте, как садится фараон. Сейчас я хочу перестать беспокоиться о себе. На следующий день мы проведем бесплатный семинар. Я хочу расслабиться, чтобы проглотить кулинарную книгу. Я не хочу пропустить плохую элиту. Завтра он будет ядовитым, но это ее собственный кот. Шоколадные подростки, к сожалению, не нанимают супергероев. Посетители будут рады записаться на урок прямо сейчас. Я ненавижу ненавидеть другую сторону. Мне жаль, но лорем ипсум будет здесь. Я хотела сказать тебе, как сильно мне хотелось арахисового масла. Но теперь проживет немного дольше. Смеясь над ультрамидами, мой шаблон меня не беспокоил. Но я всегда смеюсь над Ником из бюро косметики для беременных.";

            string[] sentences = text.Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> result = new List<string>();

            foreach (string sentence in sentences)
            {
                string[] words = sentence.Split(new[] { ' ', ',', '.', ':', ';', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                HashSet<string> uniqueWords = new HashSet<string>();

                foreach (string word in words)
                {
                    if (uniqueWords.Contains(word))
                    {
                        result.Add(sentence);
                        break;
                    }
                    else
                    {
                        uniqueWords.Add(word);
                    }
                }
            }

            Console.WriteLine("Предложения с повторяющимися словами:");
            foreach (string sentence in result)
            {
                Console.WriteLine(sentence);
            }
        }
    }
}