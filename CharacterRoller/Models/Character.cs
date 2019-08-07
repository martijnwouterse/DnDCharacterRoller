﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterRoller.Models
{
    public class Character
    {
        [Key]
        public string Id { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Proficiency { get { return (int)MathF.Round(this.Level / 4) + 1; } }

        #region Ability Scores
        public Ability Strength { get; set; }
        public Ability Dexterity { get; set; }
        public Ability Constitution { get; set; }
        public Ability Intelligence { get; set; }
        public Ability Wisdom { get; set; }
        public Ability Charisma { get; set; }
        #endregion

        #region Skills
        public Skill Acrobatics { get; set; }
        public Skill animalHandling { get; set; }
        public Skill Arcana { get; set; }
        public Skill Athletics { get; set; }
        public Skill Deception { get; set; }
        public Skill History { get; set; }
        public Skill Insight { get; set; }
        public Skill Intimidation { get; set; }
        public Skill Investigation { get; set; }
        public Skill Medicine { get; set; }
        public Skill Nature { get; set; }
        public Skill Perception { get; set; }
        public Skill Performance { get; set; }
        public Skill Persuasion { get; set; }
        public Skill Religion { get; set; }
        public Skill sleightOfHand { get; set; }
        public Skill Stealth { get; set; }
        public Skill Suvival { get; set; }
        #endregion

        public Race race { get; set; } = new Race();

        public Class characterClass { get; set; } = new Class();
    }

    public class Race
    {
        [Key]
        public string Id { get; set; }
        public Dictionary<string, int> abilityScoreImprovements = new Dictionary<string, int>
        {
            {"Strenght", 0 },
            {"Dexterity", 0 },
            {"Constitution", 0 },
            {"Intelligence", 0 },
            {"Wisdom", 0 },
            {"Charisma", 0 }
        };

        public Dictionary<string, string> raceFeatures = new Dictionary<string, string>();

        public Race()
        {
            this.Id = this.ToString();
        }
    }

    public class Class
    {
        [Key]
        public string Id { get; set; }
        public List<Dictionary<string, int>> abilityScoreImprovements = new List<Dictionary<string, int>>();
        public Dictionary<string, string> classFeatures = new Dictionary<string, string>();

        public Class()
        {
            this.Id = this.ToString();
        }
    }

    public class Ability
    {
        
        public string Id { get; set; }
        public bool Proficient { get; internal set;  }
        private int baseValue;
            
        public int BaseValue { get { return baseValue; } internal set { baseValue = value; } }

        public int Value { get
            {
                int returnValue = baseValue;
                if (this.Proficient)
                {
                    returnValue += this.parentCharacter.Proficiency;
                }
                foreach (KeyValuePair<string, int> improvement in this.parentCharacter.race.abilityScoreImprovements)
                {
                    if (improvement.Key == this.ToString())
                    {
                        returnValue += improvement.Value;
                    }
                }

                foreach (Dictionary<string, int> abilityScoreImprovement in this.parentCharacter.characterClass.abilityScoreImprovements)
                {
                    foreach (KeyValuePair<string, int> improvement in abilityScoreImprovement)
                    {
                        if (improvement.Key == this.ToString())
                        {
                            returnValue += improvement.Value;
                        }
                    }
                }

                return returnValue;
            } }

        public int Bonus { get { return (int)MathF.Floor((this.Value - 10) / 2); } }
        private Character parentCharacter;
        public string parentCharacterId { get { return this.parentCharacter.Id; } internal set { parentCharacterId = value; } }
        public Ability()
        {
            this.Id = this.ToString();
        }

        public Ability(Character character, int value, bool proficiency)
        {
            this.baseValue = value;
            this.Proficient = proficiency;
            this.parentCharacter = character;
            this.Id = this.ToString();
            this.parentCharacterId = parentCharacter.Id;
        }
    }

    public class Skill
    {
        [Key]
        public string Id { get; set; }
        private Character parentCharacter;
        public string parentCharacterId { get { return this.parentCharacter.Id; } internal set { parentCharacterId = value; } }
        public bool Proficient { get; set; } = false;
        public bool Expertise { get; set; } = false;

        public Ability parentAbility { get; set; }

        public int value {get
         {
                int returnValue = this.parentAbility.Bonus;
                if (this.Proficient)
                {
                    returnValue += parentCharacter.Proficiency;
                }

                return returnValue;
        } }

        public Skill()
        {

        }

        public Skill(Character character)
        {
            this.parentCharacter = character;
            this.parentCharacterId = parentCharacter.Id;

            switch (this.ToString())
            {
                case "Acrobatics":
                    this.parentAbility = this.parentCharacter.Dexterity;
                    break;
                case "animalHandling":
                    this.parentAbility = this.parentCharacter.Wisdom;
                    break;
                case "Arcana":
                    this.parentAbility = this.parentCharacter.Intelligence;
                    break;
                case "Athletics":
                    this.parentAbility = this.parentCharacter.Strength;
                    break;
                case "Deception":
                    this.parentAbility = this.parentCharacter.Charisma;
                    break;
                case "History":
                    this.parentAbility = this.parentCharacter.Intelligence;
                    break;
                case "Insight":
                    this.parentAbility = this.parentCharacter.Wisdom;
                    break;
                case "Intimidation":
                    this.parentAbility = this.parentCharacter.Charisma;
                    break;
                case "Investigation":
                    this.parentAbility = this.parentCharacter.Intelligence;
                    break;
                case "Medicine":
                    this.parentAbility = this.parentCharacter.Wisdom;
                    break;
                case "Nature":
                    this.parentAbility = this.parentCharacter.Intelligence;
                    break;
                case "Perception":
                    this.parentAbility = this.parentCharacter.Wisdom;
                    break;
                case "Performance":
                    this.parentAbility = this.parentCharacter.Charisma;
                    break;
                case "Persuasion":
                    this.parentAbility = this.parentCharacter.Charisma;
                    break;
                case "Religion":
                    this.parentAbility = this.parentCharacter.Intelligence;
                    break;
                case "sleightOfHand":
                    this.parentAbility = this.parentCharacter.Dexterity;
                    break;
                case "Stealth":
                    this.parentAbility = this.parentCharacter.Dexterity;
                    break;
                case "Survival":
                    this.parentAbility = this.parentCharacter.Dexterity;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            this.Id = this.ToString();
        }
    }
}