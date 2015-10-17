- title : Functionland: A Romance of Many Paradigms 
- description : An F# workshop
- author : Troy Kershaw
- theme : night
- transition : linear

***

# Functionland
## A Romance of Many Paradigms

by [@troykershaw](https://twitter.com/troykershaw)

<small>(Press 's' to read the story)</small>

***

# ZZZZzzzz....

' "Wake up!" you hear your mum yell. "You'll be late for the hackathon!"
' 
' You roll over and peer at your clock. It's 8.42, only 18 minutes shy of Functionland's annual hackathon! The hackathon gives students the chance to win a place at the prestigous Functionland Knight Academy. 
' 
' Your heart swells with a distinct feeling of global pride as you think about Functionland, the only home you have ever known. Selection for the Functionland Knight Academy would be an honour beyond description.
' You quickly put on your favourite f# shirt and hurry to the contest.
' 
' "Don't forget to pack FSI" your mum yells after you. 

***

#### Pack your bag

Check that FSI is running on your machine.

__Beginner__  
Learn all about values

__Intermediate__  
Help your fellow devs :)


' Describe values

***

# BAM!

' As you tear down the street to the hackathon venue, you clumsily lose your footing and bowl head first into a woman. A gorgeous woman, at that. Red-faced from a combination of exertion and embarrassment, you stumble to your feet and stick out a grazed arm for the woman to grasp. You soon see that there's no need: she's already on her feet, looking fresh-faced and a little amused. 
' 
' "Keen to get hacking, I see" she quips, before disappearing down the road. 
' 
' You groan inwardly, torn between desperately wanting to see the woman again and hoping to avoid further humiliation by never seeing her again.
' 
' When you finally turn up at registration you are told:

***

#### Please write a function that takes your name and age and prints them to the console.

__Intermediate__  
Print your name in extravagant ASCII art

__Advanced__  
Do intermediate, but make it print character by character as though it's being typed by a typewriter

' Show how to print to the console
' 
' Show how a function works
' 
' Discuss type inference

***

## Registration

```fsharp
let register name age =
    printf "Name: %s; Age %d" name age
register "Link" 14
```

```
Name: Link; Age 14
val register : name:string -> age:int -> unit
val it : unit = ()
```

***

## King Alonzo speaks

' The King of Functionland rises to address the would-be hackers.' 
' "Welcome to the annual Functionland hackathon. This is where the best and brightest are given the ' opportunity to prove themselves worthy to train with the Knight Academy.
' 
' "There is just one rule."

***

# No mutability!

' "This year, the problem you need to solve to win the coveted prize is:"

***

# FizzBuzz

***

#### FizzBuzz
You must print the numbers 1 to 100 in the console, however, 
if the number is divisible by 3, print "Fizz",
if it is divisible by 5, print "Buzz",
if it is divisible by 3 and 5, print "FizzBuzz"

__Intermediate__  
Use active patterns

__Advanced__  
Play "FizzBuzzWoof" where "Woof" is divisible by 7. You must print "Fizz", "Buzz" or "Woof" if any number _contains_ or is _divisible by_ 3, 5 or 7. Words must be printed in the order given in the title.

' You have 2 minutes to check your notes before we start
' - look at list generation
' - look at pattern matching

***

## Cheat sheet

' You quickly look up your notes.
' "Okay - what elements do I need here?"

<div class="fragment">

```fsharp
for i = 1 to 100 do
	printf "%d" i
```

</div>

<div class="fragment">

```fsharp
[1..100]
|> List.iter (fun n -> ...)
```

</div>

<div class="fragment">

```fsharp
match number with
| n when n > 0 -> printfn "Greater than 0"
| n -> printfn "Less than or equal to 0"
```

</div>

***

# Ding! Ding!

' "It looks like someone has solved the problem," the king says. "Please git push your code to me."

***

## FizzBuzz

```fsharp
let mutable i = 0

while i < 101 do
    let mutable str = ""

    if i % 3 = 0 then
        str <- str + "Fizz"

    if i % 5 = 0 then
        str <- str + "Buzz"

    if str = "" then
        str <- string i

    printf "%s" str

    i <- i + 1
```

' "Close, but you're mutating" the king says. "The competition is still on!"

***

## FizzBuzz

```fsharp
let fizzBuzz number =
    match number with
    | n when n % 15 = 0 -> "FizzBuzz"
    | n when n % 3 = 0 -> "Fizz"
    | n when n % 5 = 0 -> "Buzz"
    | n -> sprintf "%d" n

[1..100]
|> List.map fizzBuzz
|> List.iter (printfn "%s")
```

' You finish your solution and quickly push your code to the King.
' 
' "We have a winner!" the King announces. "Come up and claim your prize."
' 
' You grip your chair, preparing to rise, but stop dead in your tracks when the King says: "Today's fastest ' problem solver is none other than my daughter, Princess Quinn!"
' 
' As the Princess takes the stage, you gasp: it's the woman from the street!
' 
' Princess Quinn faces her crowd of admirers and bows her head, preparing to receive the winner's medal. At that moment, the earth begins to tremble. A gaping hole forms right below the Princess and she is pulled inside. An evil looking man, dressed entirely in black, rises from the hole, grasping the terrified princess in his bony arms. 


***

## The Kidnapping

' "Be warned, smug Functionlanders: I shall soon rule your world!" With a snarl, he disappears down the hole, taking the flailing Princess with him.
' 
' In desperation, you launch yourself after her, but your body is thrown back by a force field now covering the hole.
' 
' The Functionland knights appear, examining the area and assessing the unexpected turn of events.
' 
' Concerned but composed, the King stands up to address the gathering.
' 
' "The man that took my daughter is the ruler of Imperativeland: a dark world whose inhabitants are imprisoned by imperative principles. We believe that he is now trying to take over our world and kidnapping the Princess will give him the power to do so.
' 
' "The hole is a portal to Imperativeland. The force field covering it appears to be locked by an ancient, unknown sequence. The knights believe that once the force field is unlocked, there will only be enough time for one person to pass through the portal before it seals again.
' 
' We are calling for everyone to prepare themselves to rescue the Princess by attempting to solve the ancient sequence."
' 
' You race to the King, eager to rescue the brilliant Princess.
' 
' "Wait", the King says. "You can't enter Imperativeland without a sword and shield. Go and see the Knight Commander and he will help you prepare."
' 
' You run to the Knight Commander.

***

## Knight Commander

<div class="fragment">

```fsharp
type NewRecord = { Property1: string; Property2: int }
```

</div>

' "So you need a sword and shield, do you?" says the Knight Commander.
' 
' "Well, with everything that's been going on, we're all out of weapons and armour. You're going to have to make your own. Do you need a refresher?"
' 
' "Okay, you define a record like this." [show fragment]
' 
' A siren goes off.
' "Sorry, I need to see what that's about. You'll have to figure the rest out on your own."

***

#### Sword and Shield

Create two records, __Sword__ and __Shield__.

A __Sword__ should have __Damage__ and __Durability__ properties.

A __Shield__ should have __Protection__ and __Durability__ properties.

Then create an instance of a sword and shield using these types.

__Intermediate__  
Create a person record and attach the sword and shield

__Advanced__
Same as intermediate but make new weapons and armour that can replace the sword and shield easily

***

## Sword and shield

```fsharp
type Sword = { Damage: int; Durability: int }
type Shield = { Protection: int; Durability: int }

let sword = { Damage = 10; Durability = 1000 }
let shield = { Protection = 5; Durability = 500 }
```

' Armed with your sword and shield, you set off to find the King.
' All of a sudden, you feel strangely dizzy. Then everything goes black.

***

' You wake up to find yourself imprisoned in some sort of cell. On the other side of the bars you spy a handful of your hackathon competitors.
' 
' "Welcome back" one of them sneers. "I'm afraid you were getting too close. We had no choice but to stop you. Enjoy yourself here and please excuse us - we're off to rescue the Princess!"
' 
' And with that, they leave.
' 
' You look around and see a keypad mounted on a wall just oustide the cell door. The keypad appears to unlock the cell. You can just reach it.

***

#### Escape from prison

The code appears to require 4 digits.

You see fingerprints on the numbers 0, 4, 7 and 9.

What are the combinations you need to try?

__Beginner__  
Let's work this out together

__Advanced__  
Find all the possible combinations

__Expert__  
Find all the possible combinations for 'n' digits

***

## Escape from prison

```
let possibilities = [0; 4; 7; 9]
for i in possibilities do
    for j in possibilities do
        for k in possibilities do
            for l in possibilities do
                if i <> j && i <> k && i <> l && j <> k && j <> l && k <> l then
                    printfn "%d %d %d %d" i j k l
```

' Here's an imperative way to solve the problem.


***

## Escape from prison

```fsharp
let rec combinations acc set = seq {
    match set with
    | [] -> yield acc
    | s ->
        for n in s do
            yield!
                set
                |> List.filter (fun s -> s <> n)
                |> combinations (n::acc)
}

[0; 4; 7; 9]
|> combinations []
|> Seq.iter (printfn "%A")
```

' And something a little more functional.
' 
' The cell door swings open, you grab your sword and shield and you set off again for the King.
' 
' "What took you so long?" cries the King in distress. "No one has unlocked the force field yet!"
' 
' As you near the force field, a knight approaches you with a screen.
' "We've determined that the force field is based on some ancient sequence called Fibonacci. Our top mathematicians think that you need to enter in 50 values."


***

#### Print the first 50 numbers in the Fibonacci sequence.
The Fibonacci sequence is generated by adding the previous two terms.
By starting with 1 and 2, the first 10 terms will be:

```
1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
```

__Intermediate__  
Use an infinite sequence

__Advanced__  
Play code golf


*** 

## Fibonacci sequence

```fsharp
let fibSeq = (1L,1L) |> Seq.unfold (fun (a, b) -> Some(b, (b, a+b)) )

fibSeq
|> Seq.take 50
|> Seq.iter (printfn "%d")
```

' The force field jitters and disappears. You step in and...

***

## To be continued ...
