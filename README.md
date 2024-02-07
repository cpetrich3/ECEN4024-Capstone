# ECEN4024 Capstone Project

This repo contains all software related to the development of our 4-DOF motion platform ocean simulator capstone project, sponsored by Lawrence Livermore National Laboratory in conjunction with Oklahoma State University.

Current design goals neccesitate three distictive pieces of software, any of which that aren't available already as open-source solutions will need to be developed and documented here. These three software solutions consist of:

1. A GUI interface for a user to interact with our motion platform, in the form of either inputing manual positioning, or uploading pre-computed motion data derived from wave spectrum data.
2. An ocean wave simulator capable of deriving motion data in the form of an elevation and normal vector from the surface of a plane being modulated by a parameterized spectrum equation using the technique found in [[Ref. 1]](#references).
3. An inverse kinematic solver capable of solving the inverse kinematic equations that govern the motion of our platform using the data from the wave simulator as its input.

---

# References (So far)

1. https://people.computing.clemson.edu/~jtessen/reports/papers_files/coursenotes2004.pdf
2. https://github.com/GarrettGunnell/Water/tree/main
3. https://wikiwaves.org/Ocean-Wave_Spectra
4. https://gpuopen.com/gdc-presentations/2019/gdc-2019-agtd6-interactive-water-simulation-in-atlas.pdf
5. https://github.com/iamyoukou/fftWater
