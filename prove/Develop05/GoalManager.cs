public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private List<string> _levels = new List<string> 
    {
        "Aspiring Dreamer", "Novice Achiever", "Rising Star", "Goal Getter",
        "Motivated Mover", "Target Tracker", "Milestone Master", "Progress Pioneer",
        "Ambitious Adventurer", "Visionary Voyager", "Success Seeker", "Goal Guru",
        "Achievement Alchemist", "Mission Maestro", "Objective Oracle", "Goal Conqueror",
        "Mastery Maven", "Challenge Champion", "Triumph Titan", "Ultimate Achiever",
        "Supreme Overlord of Accomplishment"
    };

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        List<string> menuOptions = new List<string>
        {
            "Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Event", "Quit"
        };

        List<string> validInputs = new List<string> { "1", "2", "3", "4", "5", "6" };
        
        string choice = "";
        do
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            foreach (string option in menuOptions)
            {
                Console.WriteLine($"  {menuOptions.IndexOf(option) + 1}. {option}");
            }
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            while (!validInputs.Contains(choice))
            {
                Console.WriteLine("Not a valid option!\n");
                Console.Write("Select a choice from the menu: ");
                choice = Console.ReadLine();
            }

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                default:
                    break;
            }
        }
        while (choice != "6");
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points. {GetLevel()}\n");
    }

    private void ListGoalNames()
    {
        Console.Clear();
        Console.WriteLine("The goals are:");
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{_goals.IndexOf(goal) + 1}. {goal.GetName()}");
        }
    }

    private void ListGoalDetails()
    {
        Console.Clear();
        Console.WriteLine("The goals are:");
        foreach(Goal goal in _goals)
        {
            string completed = goal.IsComplete() ? "X" : " "; 
            Console.WriteLine($"{_goals.IndexOf(goal) + 1}. [{completed}] {goal.GetDetailsString()}");
        }
        Console.WriteLine();
    }

    private void CreateGoal()
    {
        List<string> goalTypes = new List<string>
        {
            "Simple Goal", "Eternal Goals", "Checklist Goals"
        };

        Console.Clear();
        Console.WriteLine("The types of Goals are:");
        foreach (string item in goalTypes)
        {
            Console.WriteLine($"  {goalTypes.IndexOf(item) + 1}. {item}");
        }

        string type = "";
        List<string> validInputs = new List<string> { "1", "2", "3" };

        do
        {
            Console.Write("Which type of goal would you like to create? ");
            type = Console.ReadLine();

            if (!validInputs.Contains(type))
            {
                Console.WriteLine("Not a valid type!\n");
            }
        } while (!validInputs.Contains(type));

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        int points = GetInt("What is the amount of points associated with this goal? ");

        switch (type)
        {
            case "1":
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                _goals.Add(simpleGoal);
                break;
            case "2":
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
                break;
            case "3":
                int target = GetInt("How many times does this goal need to be accomplished for a bonus? ");
                int bonus = GetInt("What is the bonus for accomplishing it that many times? ");
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(checklistGoal);
                break;
            default:
                Console.WriteLine("Not a valid type!");
                break;
        }

        Console.Clear();
    }

    private void RecordEvent()
    {
        int goalNumber;
        do 
        {
            ListGoalNames();
            goalNumber = GetInt("Which goal did you accomplish? ");

            if (goalNumber > _goals.Count() || goalNumber < 1)
            {
                Console.WriteLine("Not a valid goal!");
            }
        } while (goalNumber > _goals.Count() || goalNumber < 1);

        int points = _goals[goalNumber - 1].RecordEvent();

        Console.Clear();
        Console.WriteLine($"Congratulations! You have earned {points} points");
        _score += points;
        Console.WriteLine($"You now have {_score} points.\n");
    }

    private void SaveGoals()
    {
        Console.Write("What is the filename for the goals file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.Clear();
        Console.WriteLine($"Goals saved in '{filename}'!\n");
    }

    private void LoadGoals()
    {
        _goals.Clear();
        string filename;
        do
        {
            Console.Write("What is the filename for the goal file? ");
            filename = Console.ReadLine();
            try 
            {
                System.IO.File.ReadAllLines(filename);
                break;
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found!");
                Console.WriteLine(ex.Message);
            }
        } while (true);

        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            if (parts.Length == 1)
            {
                continue;
            }

            // Get Info
            string[] goalTypeAndName = parts[0].Split(":");
            string goalType = goalTypeAndName[0];
            string name = goalTypeAndName[1];
            string description = parts[1];
            int points = int.Parse(parts[2]);

            switch (goalType)
            {
                case "SimpleGoal":
                    string isComplete = parts[3];
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);

                    if (isComplete == "True")
                    {
                        simpleGoal.RecordEvent();
                    }

                    _goals.Add(simpleGoal);
                    break;
                case "EternalGoal":
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);

                    _goals.Add(eternalGoal);
                    break;
                case "ChecklistGoal":
                    int bonus = int.Parse(parts[3]);
                    int target = int.Parse(parts[4]);
                    int amountCompleted = int.Parse(parts[5]);

                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                    for (int i = 0; i < amountCompleted; i++)
                    {
                        checklistGoal.RecordEvent();
                    }
                    _goals.Add(checklistGoal);
                    break;
            }
        }

        Console.Clear();
        Console.WriteLine($"File '{filename}' loaded successfully!\n");
    }

    private int GetInt(string text)
    {
        int input;
        bool isInt;
        do
        {
            Console.Write(text);
            string inputString = Console.ReadLine();
            isInt = int.TryParse(inputString, out input);

            if (!isInt)
            {
                Console.WriteLine("Not valid input!\n");
            }
        } while (!isInt);

        return input;
    }

    private string GetLevel()
    {
        int level = _score / 250;

        if (level >= 20)
        {
            return $"Level 20 - {_levels[20]}";
        }

        return $"Level {level} - {_levels[level]}";
    }
}