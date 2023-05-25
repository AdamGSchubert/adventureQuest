namespace Quest
{
    public class Hat
    {
        public int ShininessLevel {get; set;}

        public string ShininessDescription()
        {
            string shinyLevel = "okay";
            if (ShininessLevel < 2)
            {
                shinyLevel = "dull";
            }
            else if (ShininessLevel < 5 && ShininessLevel > 2)
            {
                shinyLevel = "noticable";
            }
            else if (ShininessLevel < 9 && ShininessLevel > 6)
            {
                shinyLevel = "bright";
            }
            else if (ShininessLevel > 9)
            {
                shinyLevel = "blinding";
            }

            return $"your hats shininess is {shinyLevel}";
        } 
    }
}