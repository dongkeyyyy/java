.animation {
	animation: bounce-out-fwd 1.5s both;
}

@keyframes animation {
    0% {
      transform: translateZ(0);
      animation-timing-function: ease-out;
    }
    5% {
      transform: translateZ(90px);
      animation-timing-function: ease-in;
    }
    15% {
      transform: translateZ(0);
      animation-timing-function: ease-out;
    }
    25% {
      transform: translateZ(95px);
      animation-timing-function: ease-in;
    }
    38% {
      transform: translateZ(0);
      animation-timing-function: ease-out;
    }
    52% {
      transform: translateZ(150px);
      animation-timing-function: ease-in;
    }
    70% {
      transform: translateZ(0);
      animation-timing-function: ease-out;
    }
    85% {
      opacity: 1;
    }
    100% {
      transform: translateZ(500px);
      animation-timing-function: ease-in;
      opacity: 0;
    }
  }
  