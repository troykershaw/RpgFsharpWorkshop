- title : Functionland: A Romance of Many Paradigms 
- description : An F# workshop
- author : Troy Kershaw
- theme : night
- transition : linear

***

# Functionland
## A romance of many paradigms

***

# ZZZZzzzz...

<aside class="notes">
"Wake up!" you hear your mum yell. "You'll be late for the hackathon!"
You roll over and see that it's 9:42, only 18 minutes until the annual hackathon.
You quickly put on your favourite f# shirt and hurry to the contest.
The hackathon is held every year and gives students the chance to win a place in the Functionland Knight Academy.
</aside>

***

# BAM!

<aside class="notes">
Dazed, you get up off the ground and realise that you have just bumped into the princess.
"Running late as usual?" the Princess asks. "C'mon, it's about to start."
You turn up at registration and are told
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
The king stands up to speak
"Welcome to the annual Functionland hackathon. This is where the best and brightest are given the opportunity to prove themselves worthy to train with the Knight Academy.

There are some rules, however. In fact, just one.
</aside>

***

# No mutability!

<aside class="notes">
This year, the problem you need to solve to win this coveted prize is:
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
Okay - what elements do I need here?
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
"It looks like someone has solved the problem" the king says. "Please git push your code to me."
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
	
</aside>

***

# You win!

<aside class="notes">
"We have a winner!" the king announces. "Come up and take your prize"
You walk up the steps towards the king. The princess steps forward and holds up a medal, ready to place around your neck. "Try to not bowl me over this time" she says with a smile.
As she places the medal around your neck, the earth begins to tremble. A gaping hole opens up right below the princess and she falls in. An evil man, dressed entirely in black rises from the hole, floating in the air, with the princess grasped in his arms.

"I shall rule your world soon!" He cries out as he quickly disappears down the hole again.

You quickly dive in after her, but you're thrown back by a force field that now covers the hole, preventing anyone from following.

The Functionland knights quickly cover the area and assess what has happened.

Soon the King stands up to address everyone.

"The man that took my daughter is the ruler of Imperativeland. A dark world where the inhabitants are imprisoned by imperative principles. We believe that he is now trying to take over our world and kidnapping the princess will give him the power to do so.

"The force field over the hole appears to be locked by an ancient sequence. The Knights believe that once opened there will be only time to send one person down the hole.

"We are calling for everyone to prepare themselves to rescue the princess, and attempt to solve the ancient sequence problem."

You quickly race to the King, eager to go to the rescue.

"Hold on there", the King says. "You can't go down there without a sword and shield. Go and see the Knight commander and he will help you get ready."

You quickly race to see the Knight commander.
</aside>

***

## Knight commander

<aside class="notes">
"So, you need a sword do you?" says the Knight commander.
"Well, with everything going on, we're out of weapons. You're going to have to make your own. Do you need a refresher?"

"Okay, you define a record like, this"

Siren goes off
"Sorry, I need to see what that's all about. You'll have to figure the rest out on your own."

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
Armed with your sword and shield you race back to see the King.
Then all of a sudden you start feeling dizzy and everything goes black
</aside>

***

<aside class="notes">
You wake up to find yourself in a prison. Outside the bars you see some of the people you were competing with in the hackathon.

"Oh, you're awake" one of them remarks. "You were getting to close. We had to put a stop to you, so you'll have to stay here while we rescue the princess."

They all leave.

You look around the room and see the keypad to unlock the cell. You can just reach it.
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
Here's an imperative way to solve the problem
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

The cell door opens and once again you race to the King.

"What took you so long!" the King remarked. "Anyway, no one has unlocked the force field yet."

You step up to the force field and a knight approaches you with a screen.
"What we have been able to figure out" he says, "is that it is based on some ancient sequence called Fibonacci. Our top mathematicians think that you need to enter in 50 values"
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
