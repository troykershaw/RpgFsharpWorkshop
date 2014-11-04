- title : Functionland: A Romance of Many Paradigms 
- description : An F# workshop
- author : Troy Kershaw
- theme : night
- transition : linear

***

# Functionland
## A Romance of Many Paradigms

@troykershaw

***

# ZZZZzzzz...

<aside class="notes">
"Wake up!" you hear your mum yell. "You'll be late for the hackathon!"
You roll over and peer at your clock. It's 9.42, only 18 minutes shy of Functionland's annual hackathon! The hackathon gives students the chance to win a place at the prestigous Functionland Knight Academy. 
Your heart swells with a distinct feeling of global pride as you think about Functionland, the only home you have ever known. Selection for the Functionland Knight Academy would be an honour beyond description.
You quickly put on your favourite f# shirt and hurry to the contest.
</aside>

***

# BAM!

<aside class="notes">
As you tear down the street to the hackathon venue, you clumsily lose your footing and bowl head first into a woman. A gorgeous woman, at that. Red-faced from a combination of exertion and embarrassment, you stumble to your feet and stick out a grazed arm for the woman to grasp. You soon see that there's no need: she's already on her feet, looking fresh-faced and a little amused. 
"Keen to get hacking, I see" she quips, before disappearing down the road. 
You groan inwardly, torn between desperately wanting to see the woman again and hoping to avoid further humiliation by never seeing her again.

You turn up at registration and are told:
</aside>

***

## Please write a function that takes your name and age and prints them to the console.

***

## Registration

	let register name  age =
	    printf "Name: %s; Age %d" name age
	register "Link" 14

<p>
	
	[lang=?]
	Name: Link; Age 14
	val register : name:string -> age:int -> unit
	val it : unit = ()

</p>

***

## King Alonzo speaks

<aside class="notes">
The King of Functionland rises to address the would-be hackers.
"Welcome to the annual Functionland hackathon. This is where the best and brightest are given the opportunity to prove themselves worthy to train with the Knight Academy.

"There is just one rule."
</aside>

***

# No mutability!

<aside class="notes">
"This year, the problem you need to solve to win the coveted prize is:"
</aside>

***

# FizzBuzz

***

## FizzBuzz
You must print the numbers 1 to 100 in the console, however, 
if the number is divisible by 3, print "Fizz",
if it is divisible by 5, print "Buzz",
if it is divisible by 3 and 5, print "FizzBuzz"


- __Advanced__ -> Use active patterns
- __Expert__ -> Play "FizzBuzzWoof" where "Woof" is divisible by 7

<aside class="notes">
You have 2 minutes to check your notes before we start
- look at list generation
- look at pattern matching
</aside>

***

## Cheat sheet
<aside class="notes">
You quickly look up your notes.
"Okay - what elements do I need here?"
</aside>

<div class="fragment">

	for i = 1 to 100 do
    	printf "%d" i

</div>

<div class="fragment">

	[1..100]

</div>

<div class="fragment">

	match number with
	| n when n > 0 -> printfn "Greater than 0"
	| n -> printfn "Less than or equal to 0"

</div>

***

# Ding! Ding!

<aside class="notes">
"It looks like someone has solved the problem," the king says. "Please git push your code to me."
</aside>

***

## FizzBuzz

	let mutable i = 0
	while i < 101 do
	    if i % 15 = 0 then
	        printfn "FizzBuzz"
	    else if i % 3 = 0 then
	        printfn "Fizz"
	    else if i % 5 = 0 then
	        printfn "Buzz"
	    else 
	        printfn "%d" i
	    i <- i + 1

<aside class="notes">
"Close, but you're mutating" the king says. "The competition is still on!"
</aside>

***

## FizzBuzz

	let fizzBuzz number =
	    match number with
	    | n when n % 15 = 0 -> "FizzBuzz"
	    | n when n % 3 = 0 -> "Fizz"
	    | n when n % 5 = 0 -> "Buzz"
	    | n -> sprintf "%d" n

	[1..100]
	|> List.map fizzBuzz
	|> List.iter (printfn "%s")

<aside class="notes">
You finish your solution and quickly push your code to the King.

"We have a winner!" the King announces. "Come up and claim your prize."
You're sure this must be you. 
You grip your chair, preparing to rise, but stop dead in your tracks when the King says: "Today's fastest problem solver is none other than my daughter, Princess Quinn!"
As the Princess takes the stage, you gasp: it's the woman from the street!
Princess Quinn faces her crowd of admirers and bows her head, preparing to receive the winner's medal. At that moment, the earth begins to tremble. A gaping hole forms right below the Princess and she is pulled inside. An evil looking man, dressed entirely in black, rises from the hole, grasping the terrified princess in his bony arms. 
</aside>

***

## The Kidnapping

<aside class="notes">
"Be warned, smug Functionlanders: I shall soon rule your world!" With a snarl, he disappears down the hole, taking the flailing Princess with him.

In desperation, you launch yourself after her, but your body is thrown back by a force field now covering the hole.

The Functionland knights appear, examining the area and assessing the unexpected turn of events.

Concerned but composed, the King stands up to address the gathering.

"The man that took my daughter is the ruler of Imperativeland: a dark world whose inhabitants are imprisoned by imperative principles. We believe that he is now trying to take over our world and kidnapping the Princess will give him the power to do so.

"The hole is a portal to Imperativeland. The force field covering it appears to be locked by an ancient, unknown sequence. The knights believe that once the force field is unlocked, there will only be enough time for one person to pass through the portal before it seals again.
We are calling for everyone to prepare themselves to rescue the Princess by attempting to solve the ancient sequence."

You race to the King, eager to rescue the brilliant Princess.

"Wait", the King says. "You can't enter Imperativeland without a sword and shield. Go and see the Knight Commander and he will help you prepare."

You run to the Knight Commander.
</aside>

***

## Knight Commander

<aside class="notes">
"So you need a sword and shield, do you?" says the Knight Commander.
"Well, with everything that's been going on, we're all out of weapons and armour. You're going to have to make your own. Do you need a refresher?"

"Okay, you define a record like this." [show fragment]

A siren goes off.
"Sorry, I need to see what that's about. You'll have to figure the rest out on your own."

</aside>

<div class="fragment">

	type NewRecord = { Property1: string; Property2: int }

</div>

<div class="fragment">
Create two record types, Weapon and Armour.

A Weapon should have Damage and Durability properties.

Armour should have Protection and Durability properties.

Then create a sword and shield using these types.
</div>

***

## Sword and shield

	type Weapon = { Damage: int; Durability: int }
	type Armour = { Protection: int; Durability: int }

	let sword = { Damage = 10; Durability = 1000 }
	let shield = { Protection = 5; Durability = 500 }

<aside class="notes">
Armed with your sword and shield, you set off to find the King.
All of a sudden, you feel strangely dizzy. Then everything goes black.
</aside>

***

<aside class="notes">
You wake up to find yourself imprisoned in some sort of cell. On the other side of the bars you spy a handful of your hackathon competitors.

"Welcome back" one of them sneers. "I'm afraid you were getting too close. We had no choice but to stop you. Enjoy yourself here and please excuse us - we're off to rescue the Princess!"

And with that, they leave.

You look around and see a keypad mounted on a wall just oustide the cell door. The keypad appears to unlock the cell. You can just reach it.
</aside>

***

## Escape from prison

The code appears to require 4 digits.

You see fingerprints on the numbers 0, 4, 7 and 9.

What are the combinations you need to try?

***

## Escape from prison

	let possibilities = [0; 4; 7; 9]
	for i in possibilities do
	    for j in possibilities do
	        for k in possibilities do
	            for l in possibilities do
	                if i <> j && i <> k && i <> l && j <> k && j <> l && k <> l then
	                    printfn "%d %d %d %d" i j k l

<aside class="notes">
Here's an imperative way to solve the problem.
</aside>

***

## Escape from prison

	let rec combinations acc set = seq {
	    for n in set do
	        yield! combinations (n::acc) 
	        <| List.filter (fun s -> s <> n) set
	    if set = [] then yield acc
	}

	[0; 4; 7; 9]
	|> combinations []
	|> Seq.iter (printfn "%A")

<aside class="notes">
And something a little more functional.

The cell door swings open and you set off again for the King.

"What took you so long?" cries the King in distress. "No one has unlocked the force field yet!"

As you near the force field, a knight approaches you with a screen.
"We've determined that the force field is based on some ancient sequence called Fibonacci. Our top mathematicians think that you need to enter in 50 values."
</aside>

***

## Print the first 50 numbers in the Fibonacci sequence.
The Fibonacci sequence is generated by adding the previous two terms.
By starting with 1 and 2, the first 10 terms will be:

    [lang=?]
    1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

*** 

## Fibonacci sequence
	
	let fibSeq = (1L,1L) |> Seq.unfold (fun (a, b) -> Some(b, (b, a+b)) )

	fibSeq
	|> Seq.take 50
	|> Seq.iter (printfn "%d")

<aside class="notes">
The force field jitters and disappears. You step in and...
</aside>

***

## To be continued ...
