using System;

// Classe base Enemy
public class Enemy
{
    // Propriedades encapsuladas
    public int Saude { get; private set; }
    public int Velocidade { get; private set; }

    // Construtor
    public Enemy(int saudeInicial, int velocidadeInicial)
    {
        if (saudeInicial <= 0) throw new ArgumentException("A saúde deve ser positiva.");
        if (velocidadeInicial <= 0) throw new ArgumentException("A velocidade deve ser positiva.");

        Saude = saudeInicial;
        Velocidade = velocidadeInicial;
    }

    // Método para receer dano
    public void ReceberDano(int dano)
    {
        if (dano < 0) throw new ArgumentException("Dano não pode ser negativo..");
        Saude -= dano;
        Saude = Math.Max(Saude, 0); // Garante que a saúde não fique negativa
        Console.WriteLine($"Inimigo recebeu {dano} de dano. Saúde atual: {Saude}");
    }

    // Método para exibir status
    public void ExibirStatus()
    {
        Console.WriteLine($"Status do Inimigo - Saúde: {Saude}, Velocidade: {Velocidade}");
    }

    // Método para movimentar
    public virtual void Mover()
    {
        Console.WriteLine("Inimigo se move pelo cenário.");
    }

    // Método para verificar se está morto
    public bool EstaMorto() => Saude <= 0;
}

// Subclasse EnemyWithAttack
public class EnemyWithAttack : Enemy
{
    public int ForcaAtaque { get; private set; }

    public EnemyWithAttack(int saudeInicial, int velocidadeInicial, int forcaAtaqueInicial) 
        : base(saudeInicial, velocidadeInicial)
    {
        if (forcaAtaqueInicial <= 0) throw new ArgumentException("A força de ataque deve ser positiva.");
        ForcaAtaque = forcaAtaqueInicial;
    }

    // Método para atacar o jogador
    public void AtacarJogador(int dano)
    {
        Console.WriteLine($"Inimigo ataca o jogador causando {dano} de dano.");
    }

    // Sobrescrita do método mover
    public override void Mover()
    {
        Console.WriteLine("Inimigo com ataque se move de forma agressiva pelo cenário.");
    }
}

// Subclasse FlyingEnemy
public class FlyingEnemy : Enemy
{
    public int Altitude { get; private set; }

    public FlyingEnemy(int saudeInicial, int velocidadeInicial, int altitudeInicial) 
        : base(saudeInicial, velocidadeInicial)
    {
        if (altitudeInicial < 0) throw new ArgumentException("A altitude não pode ser negativa.");
        Altitude = altitudeInicial;
    }

    // Método especial para voar
    public void Voar()
    {
        Console.WriteLine($"Inimigo voa a uma altitude de {Altitude} metros.");
    }

    // Sobrescrita do método mover
    public override void Mover()
    {
        Console.WriteLine("Inimigo voador se desloca pelo ar.");
    }
}

// Subclasse StealthyEnemy
public class StealthyEnemy : Enemy
{
    public StealthyEnemy(int saudeInicial, int velocidadeInicial) : base(saudeInicial, velocidadeInicial) { }

    // Método especial para invisibilidade
    public void FicarInvisivel()
    {
        Console.WriteLine("Inimigo fica invisível e se move sem ser notado.");
    }

    public override void Mover()
    {
        Console.WriteLine("Inimigo furtivo se move silenciosamente.");
    }
}

// Classe Boss
public class Boss : Enemy
{
    private bool furioso;

    public Boss(int saudeInicial, int velocidadeInicial) : base(saudeInicial, velocidadeInicial)
    {
        furioso = false;
    }

    // Método especial para se enfurecer
    public void Enfurecer()
    {
        if (!furioso && !EstaMorto())
        {
            Console.WriteLine("O chefe ficou furioso! Habilidades aumentadas.");
            furioso = true;
        }
    }

    public override void Mover()
    {
        Console.WriteLine(furioso ? "Chefe se move com velocidade e raiva!" | "Chefe se move calmamente pelo cenário.");
    }
}
