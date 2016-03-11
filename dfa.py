import random

class DFA(object):
    def __init__(self,states,start,sigma,final,delta):
        self._states = states
        self._state = start
        self._sState = start
        self._sigma = sigma
        self._fStates = final
        self._delta = delta


    def compute(self, w):
        if len(w) == 0:
            return self._state in self._fStates
        self._state = self._delta[(self._state, w[0])]
        print('->{}'.format((self._state,w[1:])))
        return self.compute(w[1:])

    def combine(self, other):
        states=[]
        delta = {}
        finals = []
        start = self._sState + other._sState

        for s1 in self._states:
            for s2 in other._states:
                states.append(s1+s2)
                for c in self._sigma:
                    delta[(s1+s2,c)] = self._delta[(s1,c)] + other._delta[(s2,c)]

        for f1 in self._fStates:
            for f2 in other._fStates:
                    finals.append(f1+f2)

        return DFA(states,start, self._sigma, finals,delta)

    def randomize(self):
        delta={}
        for state in self._states:
            for c in self._sigma:
                delta[(state,c)] = self._states[random.randint(0,len(self._states)-1)]
        self._delta = delta
        print(len(delta))
        print(delta)



states = ['A','B']
start = 'A'
sigma = ['0','1']
final = ['B']


aut1 = DFA(states,start,sigma,final,None)
aut1.randomize()
print(aut1.compute('010'))