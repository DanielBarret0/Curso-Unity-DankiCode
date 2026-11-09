# 🏹 Jogo de Plataforma 2D em Unity

Jogo de plataforma 2D feito em **Unity 6** e **C#**, com menu, fase jogável, inimigos, coleta de moedas, sistema de vida e combate com arco. Projeto desenvolvido no curso de Unity da Danki Code.

## Funcionalidades

- **Personagem**: movimento lateral, pulo e tiro com arco, cada um com animação e som próprios
- **Combate**: flechas disparadas a partir de um ponto de tiro, dano nos inimigos e no jogador
- **Inimigos**: dois tipos (slime e guerreiro), com patrulha e dano por contato
- **Vida**: contador na tela, itens de coração que recuperam vida e game over ao zerar
- **Pontuação**: moedas coletáveis, com o total salvo entre partidas (PlayerPrefs)
- **Fluxo de jogo**: menu principal, pausa e reinício da fase
- **Câmera** que acompanha o jogador

## Controles

| Ação | Tecla |
|---|---|
| Mover | ← → / A D |
| Pular | Espaço |
| Atirar com o arco | E |
| Pausar | P |

## Stack

- Unity 6 (6000.1.4f1) com Universal Render Pipeline 2D
- C#
- Física 2D (Rigidbody2D e colisões), Animator e UI do Unity

## Estrutura

```
Curso-Unity/Assets
├── Scenes/       # Menu e Level_1
└── Scripts/
    ├── Player/   # Player1: movimento, pulo, arco, vida
    ├── Bow.cs, Cam.cs, Coin.cs, ItemHeart.cs
    ├── EnemyGuy.cs, EnemySlime.cs
    ├── GameController.cs   # pontuação, vida, pausa, game over
    └── Menu.cs, Menu_principal.cs
```

## Como abrir

1. Instale o **Unity 6000.1.4f1** pelo Unity Hub.
2. Clone o repositório e abra a pasta `Curso-Unity` no Hub.
3. Abra a cena `Assets/Scenes/Menu.unity` e clique em Play.

---

Feito por [Daniel Barreto](https://www.linkedin.com/in/daniel-barreto-developer) · [Portfólio](https://portifoliodaniel.vercel.app/)
