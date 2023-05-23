﻿using System;

namespace Home5 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GroupsCreator groupsCreator = new GroupsCreator();
            ShowBestStudents showBestStudents = new ShowBestStudents();
            RewardCreator rewardCreator = new RewardCreator();
            GroupAverage groupAverage = new GroupAverage();
            Group[] groups = groupsCreator.CreateGroups(3, 5);

            showBestStudents.ShowBestMathResults(groups);
            showBestStudents.ShowBestPhysicalEducationResults(groups);
            showBestStudents.ShowBestBiologyResults(groups);

            rewardCreator.RewardBestMathStudents(groups);
            rewardCreator.RewardBestPhysicalEducationStudents(groups);
            rewardCreator.RewardBestBiologyStudents(groups);

            groupAverage.ShowGroupAverage(groups);
            groupAverage.RewardBestGroup(groups);

            showBestStudents.ShowStudentWithMaxReward(groups);
        }
    }
}

/*
1. Coздайте класс Student, в классе используйте поля 
Id, 
Name, 
Age, 
Group, 
MathMark (Оценка по математике от 1 до 10 включительно), 
PhysicalEducationMark (Оценка по физкультуре от 1 до 10), 
BiologyMark (Оценка по биологии от 1 до 10), 
Reward (денежное вознаграждение за хорошую учебу)

Допустим есть 3 группы (Group1, Group2, Group3). 
Создайте 3 массива студентов по 5 в каждой группе. 

Оценки по дисциплинам задайте с использованием Random

Создайте метод вывода в консоль студента из каждой группы с наилучшей оценкой по Математике. 
Если существуют студенты с одинаковыми наилучшими оценками - выведите любого из них. (ex: Anton, Math mark: 10)

Создайте метод вывода в консоль студента из каждой группы с наилучшей оценкой по Физкультуре. 
Если существуют студенты с одинаковыми наилучшими оценками - выведите любого из них.

Создайте метод вывода в консоль студента из каждой группы с наилучшей оценкой по Биологии. 
Если существуют студенты с одинаковыми наилучшими оценками - выведите любого из них.

Установите каждому из лучших студентов выше - денежное вознаграждение в рублях - reward (rand: 0 - 100) (предусмотрите, чтобы нельзя было установить значение reward < 1 рубля)

Создайте методы подсчета и вывода среднего балла группы студентов по каждой из дисциплин и вывода этой информации в консоль (разные методы) (ex: Group1, avarage mark math: 8.3)

Создайте метод расчета среднего балла группы студентов по всем 3 дисциплинам (средняя оценка группы по каждой дисциплине / количество дисциплин) и выведите эту информацию в консоль. 
(Avearage mark of Group1 - Math, PhysicalEducation, Biology - 8.3)

Добавьте каждому студенту из группы с наибольшим средним баллом по всем дисциплинам произвольный reward.

Выведите на экран студента с наибольшим reward. 
Если таких студентов несколько - выведите их всех.
*/