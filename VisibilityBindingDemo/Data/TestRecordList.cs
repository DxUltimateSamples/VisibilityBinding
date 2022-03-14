namespace VisibilityBindingDemo.Data
{
    using System;
    using System.ComponentModel;

    public class TestRecordList : BindingList<TestRecord>
    {
        private static readonly string[] EventList = new[] { "Lunch", "Dinner", "Opera", "Football", "Fishing" };
        private static readonly string[] AssistantList = new[] { "Julian", "Ann", "Dick", "George", "Timmy" };

        public static TestRecordList CreateTestRecordList(int recordCount)
        {
            var list = new TestRecordList();

            for (int i = 0; i < recordCount; i++)
            {
                var day = (DayOfWeek)(i % 7);
                var @event = EventList[(i + (5 * i) + i ^ 2) % 5];
                var assistant = AssistantList[(i + (4 * i + i ^ 3)) % 5];
                var bit1 = i % 2 > 0;
                var bit2 = 2 * (i + 1) % 6 > 1;

                list.Add(i, day.ToString(), @event, assistant, bit1, bit2);
            }

            return list;
        }

        public void Add(int id, string weekDay, string @event, string assistant, bool eventVisible, bool assistantVisible)
        {
            this.Add(new TestRecord
                         {
                             Id = id,
                             Weekday = weekDay,
                             Event = @event,
                             Assistant = assistant,
                             EventVisible = eventVisible,
                             AssistantVisible = assistantVisible,
                         });
        }
    }
}