# Linguagem Csahrp

# Introdução

Este documento apresenta um guia rápido de boas práticas em C# e é voltado para iniciantes na linguagem. No entanto, também pode ser útil para desenvolvedores intermediários.

As informações apresentadas neste guia foram obtidas de alguns materiais (livros e blogs), citados nas referências, e de conhecimento prático pessoal.

Achei importante criar este material em PT_BR pois a maioria dos materiais encontrados estão escritos na língua do Tio Sam, o que dificulta um pouco o entendimento, principalmente para os iniciantes. Além disso, tentei resumir de forma bem prática e direta alguns conceitos básicos de forma que este material possa ser utilizado como um guia de consulta rápida.

Caso você não concorde com algo ou tenha alguma informação a acrescentar, sinta-se à vontade para criar issues ou enviar pull requests.

# Estilo de Código

Todo projeto possui seu estilo de código, alguns com algumas práticas mais avançadas e outros praticamente sem nenhum padrão. Porém, o estilo de código tem um grande impacto na legibilidade do mesmo. Sendo assim, é importante investir algumas horas do seu tempo para estudar um pouco sobre isso, além de realizar revisões de código sempre que possível, garantindo um código mais fácil de manter e evoluir.

## Variáveis

Bom

```
int idade;  // Correto iniciar com ZERO
int idade = 38;  // Correto iniciar com 38
var idade = 38;  // Correto iniciar com 38
```

Ruim

```
var idade;  // Errado
int Idade;  // Errado, utilizar nome de variáveis com letra minúscula
```

## Constantes

em construção...
