# Gungeon-Like-Template
A Unity Based Gungeon-Like Project Template
유니티의 URP를 기반으로 2D 렌더러가 아닌 온전히 3D 렌더러상에서 재질 및 조명을 활용할 수 있도록 벽, 바닥, 공허 타일을 설정해놓은 템플릿입니다.

## 프로젝트 요소 설명

![image](https://user-images.githubusercontent.com/39817813/150804790-20a5d15e-d730-4fda-98b8-73aef8088067.png)

Test3dTo2dTile 씬에 Floor, InnerWalls, Void 오브젝트의 자식으로 미리 정의된 타일 프리팹이 배치되어 있습니다. (각각의 카메라 프로젝션에서 잘 표시되도록 높이와 위치가 정해져 있음)

![image](https://user-images.githubusercontent.com/39817813/150805054-2a474bba-aba1-42a7-af74-0cdb2b52b45f.png)

Toggle Grid Snapping 기능을 활성화한 다음 프리팹을 해당하는 오브젝트 아래에 배치하고, 씬 뷰에서 XZ축으로 이동시키는것으로 3D 워크플로우상에서 2D와 비슷한 효과를 누릴 수 있습니다.

![image](https://user-images.githubusercontent.com/39817813/150805723-d2683323-1f0b-490f-aaca-549f0f23cbdc.png)

Agent 오브젝트의 자식으로 NavMesh를 사용하여 특정 오브젝트(\[FollowTarget\]gnome)을 추적하는 에이전트가 둘 배치되어 있습니다.

## 템플릿 사용으로 얻을 수 있는 이점

3D 프로젝트에서 사용하던 셰이더는 물론, 제한된 2D 라이팅이 아닌 3D 기반 라이트를 활용할 수 있으며, 2D 레이어가 아닌 Z깊이를 가진 공간에 스프라이트들이 배치되어있으므로, 필요에 따라 모델링 등을 스프라이트와 함께 배치하여 3D 모델링을 하이브리드로 이용할 때 문제가 없습니다.
