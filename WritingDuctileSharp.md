# How do I write Ductile#? #

Good question. This necessitates a discussion of the origins of the name as
well as some typographical conventions...

## Origins of the name ##

This project was originally going to be called "Ductile C#". Of course,
this would have had led to many of the same issues. I chose "Ductile#"
by analogy with "[DuctileJ](DuctileJ.md)" - i.e. the bit after the "Ductile" is _not_
the name of the programming language but some phrase which somehow evokes
the association. "#" is to "C#" as "J" is to Java. Clever, eh?

## Typographical conventions ##

The "#" (hash or pound sign) is actually a rendering of a sharp symbol. In
the LaTeX paper I'm writing to describe the work on this project, I render
the name of the project using my custom `\DuctileSharp` command which is
(roughly) defined as follows:

```
\newcommand{\DuctileSharp}{Ductile\kern-.005em\raise.25ex\hbox{\#}\xspace}
```

i.e. The hash character is moved up and to the right slightly.

Without the benefit of a typesetting language, I would recommend "Ductile#"
and, being a broad-minded kind of a chap, I think "DuctileSharp"
is also perfectly acceptable, particularly in environments where the
[hash character might cause difficulties](http://en.wikipedia.org/wiki/C_Sharp).
